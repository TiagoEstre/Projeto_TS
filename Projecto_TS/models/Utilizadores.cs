using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_TS.models
{
    public class Utilizadores
    {
        public string Name {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Numero { get; set; }
        public string Idade { get; set;}

        public Utilizadores(string name, string username, string password, string email)
        {
            Name = name;
            Username = username;
            Password = password;
            Email = email;
        }
    }
}
