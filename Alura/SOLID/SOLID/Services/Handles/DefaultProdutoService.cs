using SOLID.Dados.DbContext;
using SOLID.Dados.Interfaces;
using SOLID.Models;

namespace SOLID.Services.Handles
{
    public class DefaultProdutoService : IProdutoService
    {
            readonly ILeilaoDao _leilaoDao;
            readonly ICategoriaDao _categoriaDao;

            public DefaultProdutoService(ILeilaoDao leilaoDao, ICategoriaDao categoriaDao)
            {
                _leilaoDao = leilaoDao;
                _categoriaDao = categoriaDao;
            }

            public Categoria GetCategoryByIdWithAuctionsOnTradingFloor(int id)
            {
                return _categoriaDao.BuscarPorId(id);
            }

            public IEnumerable<CategoriaDaoComEF> GetCategoryWithTotalAuctionsOnTradingFloor()
            {
                //return _categoriaDao.GetAll()
                //    .Select(c => new CategoriaComInfoLeilao
                //    {
                //        Id = c.Id,
                //        Descricao = c.Descricao,
                //        Imagem = c.Imagem,
                //        EmRascunho = c.Leiloes.Where(l => l.Situacao == SituacaoLeilao.Rascunho).Count(),
                //        EmPregao = c.Leiloes.Where(l => l.Situacao == SituacaoLeilao.Pregao).Count(),
                //        Finalizados = c.Leiloes.Where(l => l.Situacao == SituacaoLeilao.Finalizado).Count(),
                //    });
            }

            public IEnumerable<Leilao> SearchAuctionsOnTradingFloor(string term)
            {
                //var termoNormalized = term.ToUpper();
                //return _leilaoDao.GetAll()
                //    .Where(c =>
                //        c.Titulo.ToUpper().Contains(termoNormalized) ||
                //        c.Descricao.ToUpper().Contains(termoNormalized) ||
                //        c.Categoria.Descricao.ToUpper().Contains(termoNormalized));
            }
        
    }
}
