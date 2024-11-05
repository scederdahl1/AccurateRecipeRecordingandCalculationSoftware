using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AccurateRecipeRecordingandCalculationSoftware
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string Preparation { get; set; }
        public int Amount { get; set; }
        public decimal Cost { get; set; }



        public Ingredient(string name, string preparation, int amount, Decimal cost)
        {
            Name = name;
            Preparation = preparation;
            Amount = amount;
            Cost = cost;
            
        }

        



    }
}
