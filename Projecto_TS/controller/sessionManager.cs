using Projecto_TS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_TS.controller
{
    public static class sessionManager
    {
        public static Utilizador CurrentUser { get; set; }

        public static void Login(Utilizador user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }
    }
}
