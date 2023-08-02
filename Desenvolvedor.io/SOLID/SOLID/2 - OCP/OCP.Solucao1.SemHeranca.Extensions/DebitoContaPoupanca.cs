using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solucao1.SemHeranca.Extensions
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarPoupanca(this DebitoConta debitoConta)
        {
            //Logica de negocio do Debito Conta Poupanca
            return debitoConta.FormatarTransacao();
        }
    }
}
