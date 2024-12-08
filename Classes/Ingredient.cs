using System;


namespace AccurateRecipeRecordingandCalculationSoftware.Classes
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string Preparation { get; set; }
        public int Amount { get; set; }
        public string Unit { get; set; }
        public decimal Cost { get; set; }



        public Ingredient(string name, string preparation, int amount, string unit, decimal cost)
        {
            Name = name;
            Preparation = preparation;
            Amount = amount;
            Unit = unit;
            Cost = cost;
        }





    }
}
