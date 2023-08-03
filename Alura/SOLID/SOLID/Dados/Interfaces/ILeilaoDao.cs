using SOLID.Models;

namespace SOLID.Dados.Interfaces
{
    public interface ILeilaoDao : IQuery<Leilao>, ICommand<Leilao>
    {
    }
}
