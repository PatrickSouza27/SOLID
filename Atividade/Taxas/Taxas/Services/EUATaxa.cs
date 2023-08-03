using Taxas.Interfaces;
using Taxas.Models;

namespace Taxas.Services
{
    public class EUATaxa : ITaxas
    {
        public double ValorTaxa(ValorTaxa taxa)
        {
            return taxa.Valor * 30 / 100;
        }
    }
}
