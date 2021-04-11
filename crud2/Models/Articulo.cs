using System;
using System.Collections.Generic;

#nullable disable

namespace crud2.Models
{
    public partial class Articulo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal? Precio { get; set; }
        public int Idcategoria { get; set; }

        public virtual Categoria IdcategoriaNavigation { get; set; }
    }
}
