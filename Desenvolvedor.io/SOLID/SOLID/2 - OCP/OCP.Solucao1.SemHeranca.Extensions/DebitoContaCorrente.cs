using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solucao1.SemHeranca.Extensions
{
    public static class DebitoContaCorrente
    {
        public static string DebitarCorrente(this DebitoConta debitoConta)
        {
            //Logica de negocio para debito em conta corrente
            return debitoConta.FormatarTransacao();
        }
    }
}
