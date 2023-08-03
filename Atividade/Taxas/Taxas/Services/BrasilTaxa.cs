using Taxas.Interfaces;
using Taxas.Models;

namespace Taxas.Services
{
    public class BrasilTaxa : ITaxas
    {
        public double ValorTaxa(ValorTaxa taxa)
        {
            return taxa.Valor * 60 / 100;
        }
    }
}
