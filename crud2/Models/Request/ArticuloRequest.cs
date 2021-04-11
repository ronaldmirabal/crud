using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud2.Models.Request
{
    public class ArticuloRequest
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int idcategoria { get; set; }
    }
}
