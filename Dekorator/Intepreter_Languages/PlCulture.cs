using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Intepreter_Languages
{
    class PlCulture : SetCulture
    {
        public PlCulture()
        {
            CultureInfo cultureInfo = new CultureInfo("Pl");
            Set(cultureInfo);
        }
        public override void Set(CultureInfo context)
        {
            Resources.Culture = context;
        }
    }
}
