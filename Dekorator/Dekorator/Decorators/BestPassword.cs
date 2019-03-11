using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Dekorator.Decorators
{
    public class BestPassword : PasswordDecorator
    {
        public BestPassword(PasswordWriter toDecorate) : base(toDecorate)
        {
        }

        public override string Save(string password)
        {
            return $"najlepsze {base.Save(password)}";
        }
    }
}
