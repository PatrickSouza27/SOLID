using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solucao1.SemHeranca.Extensions
{
    public class CaixaEletronico
    {
        public static void Operacoes()
        {
            // MenuOperacoes (exemplo 1 - saque conta corrente, 2 - saque conta poupança, 3 - saque Conta investimento) cw
            var opc = Console.ReadKey();
            var retorno = string.Empty;

            var conta = DadosDebito();
            switch (opc.KeyChar)
            {
                case '1':
                    Console.WriteLine("Efetuando operação em conta Corrente");
                    retorno = conta.DebitarCorrente();
                    break;
                case '2':
                    Console.WriteLine("Efetuando operação em conta Poupança");
                    retorno = conta.DebitarPoupanca();
                    break;
                case '3':
                    Console.WriteLine("Efetuando operação em conta Investimento");
                    retorno = conta.DebitarContaInvestimento();
                    break;
            }
            Console.WriteLine("Numero da transação: " + retorno);

        }
        private static DebitoConta DadosDebito()
        {
            var conta = Console.ReadLine();
            var valor = decimal.Parse(Console.ReadLine());

            return new DebitoConta { NumeroConta = conta, Valor = valor };
        }
    }
}
