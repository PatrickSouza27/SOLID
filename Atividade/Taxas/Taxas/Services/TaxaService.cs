using Taxas.Interfaces;
using Taxas.Models;

namespace Taxas.Services
{
    public class TaxaService
    {
        private ITaxas _taxa;
        public TaxaService(ITaxas taxa)
        {
            _taxa = taxa;
        }
        public string Service(ValorTaxa valor)
        {
            if (valor.VerificaValor())
                return "Valor Invalido";

            return "R$" + _taxa.ValorTaxa(valor).ToString();         
        }
    }
}
