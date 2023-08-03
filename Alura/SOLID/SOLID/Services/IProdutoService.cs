using SOLID.Dados.DbContext;
using SOLID.Models;

namespace SOLID.Services
{
    public interface IProdutoService
    {
        IEnumerable<Leilao> SearchAuctionsOnTradingFloor(string term);
        IEnumerable<CategoriaDaoComEF> GetCategoryWithTotalAuctionsOnTradingFloor();
        Categoria GetCategoryByIdWithAuctionsOnTradingFloor(int id);
    }
}
