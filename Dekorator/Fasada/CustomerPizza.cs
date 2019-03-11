using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Fasada
{
    public class CustomerPizza
    {
        public string GetVegetarianPizza()
        {
            PizzeriaKitchen pk = new PizzeriaKitchen();
            var result = $"{pk.GetPizzaDough()} {Environment.NewLine}" +
                $"{pk.GetPizzaTopingsWithoutMeat()} {Environment.NewLine}" +
                $"{pk.GetBakedPizza()} {Environment.NewLine}";
            return result;
        }

        public string GetMeatPizza()
        {
            PizzeriaKitchen pk = new PizzeriaKitchen();
            var result = $"{pk.GetPizzaDough()} {Environment.NewLine}" +
                $"{pk.GetPizzaTopings()} {Environment.NewLine}" +
                $"{pk.GetBakedPizza()} {Environment.NewLine}";
            return result;
        }
    }
}
