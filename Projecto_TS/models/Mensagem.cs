using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_TS.models
{
    public class Mensagem
    {
        [Key]
        public int Id { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set;}
        public int UtilizadorId { get; set; }
        public Utilizador Utilizador { get; set; }

        public Mensagem()
        {
        }
    }
}
