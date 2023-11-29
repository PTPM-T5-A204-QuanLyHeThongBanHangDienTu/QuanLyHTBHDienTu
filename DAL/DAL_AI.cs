using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Accord;
using Accord.IO;
using System.IO;
using Accord.MachineLearning;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math.Optimization.Losses;
using Accord.MachineLearning.DecisionTrees.Rules;
using Accord.Math;
using Accord.Math.Distances;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Analysis;
using Accord.Statistics.Filters;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_AI
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; Database =web_mvcphu; Uid=root");
        private DataTable dae = new DataTable();
        public DAL_AI() { }

        public DataTable LoadDL()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from thongke", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dae = dt;
            return dt;
        }
        public string LoadAI(string category, string price, string amount, string rank)
        {

            DecisionTree tree = Serializer.Load<DecisionTree>("tree.bin");
            DataTable data = LoadDL();
            var codebook = new Codification(data);

            int[] query = codebook.Transform(new[,]
             {
                { "category",     ""+category+""  },
                { "price", ""+price+""    },
                { "amount",    ""+amount+""   },
                { "rank",        ""+rank+"" }
            });

            int predicted = tree.Decide(query);

            string answer = codebook.Revert("result", predicted);
            return answer;
        }
        public DecisionTree HuanLuyen()
        {
            DataTable data = LoadDL();


            var codebook = new Codification(data);

            DataTable symbols = codebook.Apply(data);
            int[][] inputs = symbols.ToArray<int>("category", "price", "amount", "rank");
            int[] outputs = symbols.ToArray<int>("result");
            var id3learning = new ID3Learning()
            {

                new DecisionVariable("category",3),
                new DecisionVariable("price",4),
                new DecisionVariable("amount",3),
                new DecisionVariable("rank",5),
            };
            DecisionTree tree = id3learning.Learn(inputs, outputs);
            double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));

            tree.Save("tree.bin");
            return tree;
        }
    }
}
