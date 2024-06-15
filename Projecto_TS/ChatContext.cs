using Projecto_TS.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_TS
{
    internal class ChatContext : DbContext
    {
        public DbSet<Utilizador> utilizadors {  get; set; }

        
    }
}
