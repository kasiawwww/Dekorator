using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Kompozyt
{
    public abstract class Component
    {
        public virtual void Add(Component component) { }
        public virtual void Delete(Component component) { }
        public abstract bool IsComposite();
        public abstract string Show();

    }
}
