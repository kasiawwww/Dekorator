using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Intepreter_Languages
{
    class EnCulture : SetCulture
    {
        public EnCulture()
        {
            CultureInfo cultureInfo = new CultureInfo("En");
            Set(cultureInfo);
        }
        public override void Set(CultureInfo context)
        {
            Resources.Culture = context;
        }
    }
}
