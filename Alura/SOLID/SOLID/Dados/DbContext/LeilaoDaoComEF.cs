using SOLID.Dados.Interfaces;
using SOLID.Models;

namespace SOLID.Dados.DbContext
{
    public class LeilaoDaoComEF : ILeilaoDao
    {
        AppDbContext _context;
        public LeilaoDaoComEF(AppDbContext context)
        {
            _context = context;
        }

        public Leilao BuscarPorId(int Id)
        {
            //_context.Categorias.FirstOrDefault(x=> x.Id == Id); Entity framework retornando a categoria
        }
        public List<Leilao> BuscarTodos()
        {
            //_context.Categorias.ToList(); Entity framework retornando todas as categoria
        }
        public void Incluir(Leilao leilao)
        {
            //INSERT Leilao tabela
            //_context.Leilao.add(leilao)
            //_context.SaveChanges();
        }
        public void Alterar(Leilao leilao)
        {
            //Alterar Leilao tabela
            //_context.Leilao.add(leilao)
            //_context.SaveChanges();
        }
        public void Excluir(Leilao leilao)
        {
            //Excluir Leilao tabela
            //_context.Leilao.add(leilao)
            //_context.SaveChanges();
        }
    }
}
