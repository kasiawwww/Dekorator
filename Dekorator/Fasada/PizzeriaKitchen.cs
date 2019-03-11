using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Fasada
{
    public class PizzeriaKitchen
    {
        public string GetPizzaDough()
        {
            PizzaDough pd = new PizzaDough();
            var result = $"{pd.AddWater()} {Environment.NewLine}" +
                $"{pd.AddSalt()} {Environment.NewLine}" +
                $"{pd.AddFlour()} {Environment.NewLine}" +
                $"{pd.AddYeast()} {Environment.NewLine}";
            return result;
        }

        public string GetPizzaDoughWithoutSalt()
        {
            PizzaDough pd = new PizzaDough();
            var result = $"{pd.AddWater()} {Environment.NewLine}" +
                $"{pd.AddFlour()} {Environment.NewLine}" +
                $"{pd.AddYeast()} {Environment.NewLine}";
            return result;
        }

        public string GetPizzaTopings()
        {
            PizzaTopings pt = new PizzaTopings();
            var result = $"{pt.AddTomatoSauce()} {Environment.NewLine}" +
                $"{pt.AddHam()} {Environment.NewLine}" +
                $"{pt.AddCheese()} {Environment.NewLine}" +
                $"{pt.AddOlivs()} {Environment.NewLine}";
            return result;
        }

        public string GetPizzaTopingsWithoutMeat()
        {
            PizzaTopings pt = new PizzaTopings();
            var result = $"{pt.AddTomatoSauce()} {Environment.NewLine}" +
                $"{pt.AddCheese()} {Environment.NewLine}" +
                $"{pt.AddOlivs()} {Environment.NewLine}";
            return result;
        }

        public string GetBakedPizza()
        {
            PizzaBake pb = new PizzaBake();
            var result = $"{pb.Bake()} {Environment.NewLine}";
            return result;
        }
    }
}
