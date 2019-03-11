using Dekorator.Dekorator;
using Dekorator.Dekorator.Decorators;
using Dekorator.Fasada;
using Dekorator.Intepreter_Languages;
using Dekorator.Interpreter;
using Dekorator.Kompozyt;
using Dekorator.Pelnomocnik;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dekorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEKORATOR
            //PasswordWriter passwordWriter = new MyPasswordWriter();
            //Console.WriteLine(passwordWriter.Save("kasia"));

            //// Do password writer przypisaywany jest nowy udekorowany obiekt
            //passwordWriter = new BestPassword(passwordWriter);
            //Console.WriteLine(passwordWriter.Save("kasia1"));

            //passwordWriter = new ConcretePassword(passwordWriter);
            //Console.WriteLine(passwordWriter.Save("k"));

            //PELNOMOCNIK
            //Console.WriteLine("Wprowadzony użytkownik: user, hasło: user");
            //ProxyPermisions proxyUser = new ProxyPermisions("user", "user");
            //Console.WriteLine($"Jest adminem: {proxyUser.IsAuthenticated()}");
            //Console.WriteLine("Wprowadzony użytkownik: admin, hasło: admin");
            //ProxyPermisions proxyAdmin = new ProxyPermisions("admin", "admin");
            //Console.WriteLine($"Jest adminem: {proxyAdmin.IsAuthenticated()}");
            //Console.WriteLine("Wprowadzony użytkownik: kasia, hasło: kasia");
            //ProxyPermisions proxyKasia = new ProxyPermisions("kasia", "kasia");
            //Console.WriteLine($"Jest adminem: {proxyKasia.IsAuthenticated()}");
            //Console.ReadLine();

            //COMPOSITE
            //var Tree = new Composite();
            //var branch = new Composite();
            //branch.Add(new Leaf());
            //branch.Add(new Leaf());
            //branch.Add(new Leaf());
            //var branch2 = new Composite();
            //branch2.Add(new Leaf());
            //branch2.Add(new Leaf());

            //Tree.Add(branch);
            //Tree.Add(branch2);

            //Console.WriteLine(Tree.Show());

            //FASADA
            //PizzeriaKitchen pk = new PizzeriaKitchen();

            //Console.WriteLine(pk.GetPizzaDough());
            //Console.WriteLine(pk.GetPizzaTopings());
            //Console.WriteLine(pk.GetBakedPizza());
            //Console.Read();

            //CustomerPizza cp = new CustomerPizza();

            //Console.WriteLine(cp.GetVegetarianPizza());

            //Console.Read();


            //INTERPRETER
            //var context = new Context();
            //var list = new List<AbstractExpression>();

            //list.Add(new TerminalExpression());
            //list.Add(new NonterminalExpression());
            //list.Add(new TerminalExpression());
            //list.Add(new TerminalExpression());

            //foreach (AbstractExpression exp in list)
            //{
            //    Console.WriteLine(exp.Interpret(context));
            //}

            //INTERPRETER2
            string cultureString = "";
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.P:
                    new PlCulture();
                    break;
                case ConsoleKey.E:
                    new EnCulture();
                    break;
                default:
                    Console.WriteLine("Nieznany język");
                    return;
            }
            //string cultureString = Console.ReadLine();
            CultureInfo cultureInfo = new CultureInfo(cultureString);
            //Thread.CurrentThread.CurrentCulture = cultureInfo;
            
            Console.WriteLine(Resources.name);
            Console.WriteLine(Resources.lastName);
            Console.Read();
        }
    }
}
