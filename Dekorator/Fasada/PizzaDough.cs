using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Fasada
{
    public class PizzaDough
    {
        public string AddWater()
        {
            return "Water";
        }
        public string AddSalt()
        {
            return "Salt";
        }
        public string AddFlour()
        {
            return "Flour";
        }
        public string AddYeast()
        {
            return "Yeast";
        }
    }
}
