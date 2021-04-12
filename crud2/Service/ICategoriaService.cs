using crud2.Models;
using System.Linq;

namespace crud2.Service
{
    public interface ICategoriaService
    {
        public IQueryable<Categoria> GetAll();
    }
}
