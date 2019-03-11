using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Kompozyt
{
    public class Leaf : Component
    {
        public override bool IsComposite()
        {
            return false;
        }
        public override string Show()
        {
            return "Liść";
        }
    }
}
