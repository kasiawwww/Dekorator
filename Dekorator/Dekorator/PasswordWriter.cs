using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Dekorator
{
    public abstract class PasswordWriter
    {
        public abstract string Save(string password);
    }
}
