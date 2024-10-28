using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccurateRecipeRecordingandCalculationSoftware
{
    internal class Ingredient
    {
        public string name { get; set; }
        public string preparation{ get; set; }
        public int amount { get; set; }
        public double cost { get; set; }



        public Ingredient(string name, string preparation, int amount, int cost)
        {
            this.name = name;
            this.preparation = preparation;
            this.amount = amount;
            this.cost = cost;
            
        }

        



    }
}
