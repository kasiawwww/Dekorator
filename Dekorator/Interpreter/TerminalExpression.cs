using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Interpreter
{
    class TerminalExpression : AbstractExpression
    {
        public override string Interpret(Context context)
        {
            return "Called Terminal.Interpret()";
        }
    }
}
