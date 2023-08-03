using SOLID.Models;

namespace SOLID.Dados.Interfaces
{
    public interface ICommand<T>
    {
        public void Incluir(Leilao leilao);
        public void Alterar(Leilao leilao);
        public void Excluir(Leilao leilao);
    }
}
