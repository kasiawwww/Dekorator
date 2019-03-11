using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator.Pelnomocnik
{
    class Permisions : IPermisions
    {
        //Lista użytkowników którzy mogą się zalogować.
        public Dictionary<UserPermisions, string> usersDict = new Dictionary<UserPermisions, string>()
        {
           { new UserPermisions { Name = "admin", IsAdmin = true }, "admin"},
           { new UserPermisions { Name = "user", IsAdmin = true }, "user"}
        };
        //Oryginalny obiekt nie daje dostepu.
        public bool IsAuthenticated()
        {
            return false;
        }
    }
}
