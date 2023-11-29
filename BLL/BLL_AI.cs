using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


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
namespace BLL
{
    public class BLL_AI
    {
        DAL_AI dal_al = new DAL_AI();
        public BLL_AI() { }
        public string LoadAI(string category, string price, string amount, string rank)
        {
            return dal_al.LoadAI(category, price, amount, rank);
        }

        public DecisionTree HuanLuyen()
        {
            return dal_al.HuanLuyen();
        }
    }
}
