using crud2.Models;
using crud2.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud2.Service
{
    public interface IArticuloService
    {
        public IQueryable<Articulo> GetAll();
        public void Add(ArticuloRequest request);
        public void Edit(ArticuloRequest request);
        public void Delete(int id);
    }
}
