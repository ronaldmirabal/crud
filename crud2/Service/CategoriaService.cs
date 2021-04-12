using crud2.Data;
using crud2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud2.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly DataContext _context;

        public CategoriaService(DataContext context)
        {
            _context = context;
        }
        public IQueryable<Categoria> GetAll()
        {
            return _context.Categoria.OrderByDescending(c => c.Id);
        }
    }
}
