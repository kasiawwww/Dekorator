using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Pelnomocnik
{
    class ProxyPermisions : IPermisions

    {
        string _name = "";
        string _pwd = "";
        public ProxyPermisions(string name, string pwd)
        {
            _name = name;
            _pwd = pwd;
        }
        public bool IsAuthenticated()
        {
            // Pobieramy słownik z oryginalnej klasy
            var usersDict = new Permisions().usersDict;
            if (usersDict.Where(a => a.Key.Name == _name && a.Value == _pwd).Count() > 0)
            {
                var up = usersDict.Where(a => a.Key.Name == _name && a.Value == _pwd).Select(a => a.Key).First();
                return (up != null && up.IsAdmin);
            }
            return false;
        }
    }
}
