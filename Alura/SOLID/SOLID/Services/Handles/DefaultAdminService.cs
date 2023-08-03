using SOLID.Dados.Interfaces;
using SOLID.Models;

namespace SOLID.Services.Handles
{
    public class DefaultAdminService : IAdminService
    {
        readonly ILeilaoDao _dao;
        readonly ICategoriaDao _categoryDao;

        public DefaultAdminService(ILeilaoDao dao, ICategoriaDao categoryDao)
        {
            _dao = dao;
            _categoryDao = categoryDao;
        }

        public IEnumerable<Leilao> GetAllAuctions()
        {
            return _dao.BuscarTodos();
        }

        public IEnumerable<Categoria> GetAllCategory()
        {
            return _categoryDao.BuscarTodos();
        }

        public Leilao GetAuction(int id)
        {
            return _dao.BuscarPorId(id);
        }

        public void InsertAuction(Leilao auction)
        {
            _dao.Incluir(auction);
        }

        public void UpdateAuction(Leilao auction)
        {
            _dao.Alterar(auction);
        }

        public void DeleteAuction(Leilao leilao)
        {
            _dao.Excluir(leilao);
        }

        public void StartAuctionSessionWithId(int id)
        {
            var auction = _dao.BuscarPorId(id);
            //if (auction != null && auction.Situacao == SituacaoLeilao.Rascunho)
            //{
            //    auction.Situacao = SituacaoLeilao.Pregao;
            //    auction.Inicio = DateTime.Now;
            //    _dao.Update(auction);
            //}
        }

        public void FinishAuctionSessionWithId(int id)
        {
            var auction = _dao.BuscarPorId(id);
            //if (auction != null && auction.Situacao == SituacaoLeilao.Pregao)
            //{
            //    auction.Situacao = SituacaoLeilao.Finalizado;
            //    auction.Termino = DateTime.Now;
            //    _dao.Update(auction);
            //}
        }
    }
}
