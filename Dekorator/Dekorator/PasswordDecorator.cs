using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Dekorator
{
    public abstract class PasswordDecorator : PasswordWriter
    {
        protected PasswordWriter decorated;
        public PasswordDecorator(PasswordWriter toDecorate)
        {
            decorated = toDecorate;
        }
        public override string Save(string password)
        {
            return decorated != null ? decorated.Save(password) : "null";
        }
    }
}
