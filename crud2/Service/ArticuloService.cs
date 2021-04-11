using crud2.Data;
using crud2.Models;
using crud2.Models.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud2.Service
{
    public class ArticuloService : IArticuloService
    {
        private readonly DataContext _context;

        public ArticuloService(DataContext context)
        {
            _context = context;
        }
        public void Add(ArticuloRequest request)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Articulo> GetAll()
        {
            return _context.Articulos.Include(c => c.IdcategoriaNavigation).OrderByDescending(a => a.Id);
        }
    }
}
