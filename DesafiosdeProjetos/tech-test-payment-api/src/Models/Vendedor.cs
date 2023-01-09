using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Models;

namespace src.Models
{
    public class Vendedor
    {
        public int id { get; set; }
        public String cpf { get; set; }
        public String nome {get; set;}
        public String Email { get; set; }
        public String telefone { get; set; }
    }
}