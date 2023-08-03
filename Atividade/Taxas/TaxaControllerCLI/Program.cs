using System.Text.RegularExpressions;
using Taxas.Models;
using Taxas.Services;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            char opc = ' ';
            do
            {
                Console.WriteLine("1 - Brasil / 2 - EUA");
                opc = Console.ReadKey().KeyChar;
                Thread.Sleep(100);
                Console.Clear();
            }
            while (opc != '1' && opc != '2');


            Console.WriteLine("Valor: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double valor))
            {
                if (opc == '1')
                    Console.WriteLine(new TaxaService(new BrasilTaxa()).Service(new ValorTaxa(valor)));
                if (opc == '2')
                    Console.WriteLine(new TaxaService(new EUATaxa()).Service(new ValorTaxa(valor)));
            }
            Console.WriteLine("Finalizado...");



        }
    }
}