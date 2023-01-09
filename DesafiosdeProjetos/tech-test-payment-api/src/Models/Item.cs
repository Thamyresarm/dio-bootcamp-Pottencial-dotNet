using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class Item
    {
        public int id { get; set; }
        public String produto { get; set; }
        public String descricao { get; set; }
        public int quantidade { get; set; }
        public int vendaId {get; set;}
    }
}