using System;
using System.Collections.Generic;

#nullable disable

namespace crud2.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Articulos = new HashSet<Articulo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
