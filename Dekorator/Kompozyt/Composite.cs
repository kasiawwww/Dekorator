using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Kompozyt
{
    public class Composite : Component
    {
        static bool isHighest = true;
        List<Component> leaves = new List<Component>();
        public override void Add(Component component)
        {
            leaves.Add(component);
        }

        public override void Delete(Component component)
        {
            leaves.Remove(component);
        }
        public override bool IsComposite()
        {
            return true;
        }

        public override string Show()
        {
            string result = isHighest ? "Dzrzewo\n" : "\n    Galąź \n           ";
            isHighest = false;
            leaves.ForEach(l => result += $" {l.Show()}");
            return result;
        }
    }
}
