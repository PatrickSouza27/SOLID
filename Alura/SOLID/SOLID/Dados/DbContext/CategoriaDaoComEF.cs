using SOLID.Dados.Interfaces;
using SOLID.Models;

namespace SOLID.Dados.DbContext
{
    public class CategoriaDaoComEF : ICategoriaDao
    {
        AppDbContext _context;
        public CategoriaDaoComEF(AppDbContext context)
        {
            _context = context;
        }

        public Categoria BuscarPorId(int Id)
        {
            //_context.Categorias.FirstOrDefault(x=> x.Id == Id); Entity framework retornando a categoria
        }
        public List<Categoria> BuscarTodos()
        {
            //_context.Categorias.ToList(); Entity framework retornando todas as categoria
        }

    }
}
