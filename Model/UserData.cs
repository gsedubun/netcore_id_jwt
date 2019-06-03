using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore_id_jwt.Model
{
    public class Kunci
    {
        public const string Aman = "Oke09inirahasia55663";
    }
    public class UserData
    {
        private string token;
        public string Username { get; set; }
        public string Password { get; set; }
        public void SetToken(string _t)
        {
            token = _t;
        }
        public string Token { get => token; private set => token = value; }
    }
}
