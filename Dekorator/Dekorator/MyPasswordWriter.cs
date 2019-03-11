using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Dekorator
{
    public class MyPasswordWriter : PasswordWriter
    {
        public override string Save(string password)
        {
            return $"hasło: {password}";
        }
    }
}
