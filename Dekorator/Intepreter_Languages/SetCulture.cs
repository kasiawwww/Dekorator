using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Intepreter_Languages
{
    public abstract class SetCulture
    {
        public abstract void Set(CultureInfo context);
    }
}
