using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_TS.models
{
    public class Utilizador
    {
        [Key]
        public int Id {  get; set; }
        public string Name {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Year { get; set;}
        public string Status { get; set; }  

        public Utilizador()
        {
        }
    }
}
