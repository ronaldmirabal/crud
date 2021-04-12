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
            Articulo _articulo = new Articulo();
            _articulo.Nombre = request.nombre;
            _articulo.Precio = request.precio;
            _articulo.Idcategoria = request.idcategoria;
            _context.Add(_articulo);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ArticuloRequest request)
        {
            try
            {
                Articulo _articulo = _context.Articulos.Find(request.id);
                _articulo.Nombre = request.nombre;
                _articulo.Precio = request.precio;
                _articulo.Idcategoria = request.idcategoria;
                _context.Update(_articulo);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IQueryable<Articulo> GetAll()
        {
            return _context.Articulos.Include(c => c.IdcategoriaNavigation).OrderByDescending(a => a.Id);
        }
    }
}
