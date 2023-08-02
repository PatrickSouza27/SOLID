using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solucao1.SemHeranca.Extensions
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            //Logica para DebitoContaInvestimento
            return debitoConta.FormatarTransacao();
        }
    }
}
