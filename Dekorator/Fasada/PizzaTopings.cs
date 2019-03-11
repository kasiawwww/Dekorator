using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Fasada
{
    public class PizzaTopings
    {
        public string AddOlivs()
        {
            return "Olivs";
        }
        public string AddHam()
        {
            return "Ham";
        }
        public string AddTomatoSauce()
        {
            return "TomatoSauce";
        }
        public string AddCheese()
        {
            return "Cheese";
        }
    }
}
