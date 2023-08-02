using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Solucao1
{
    // a herança nem sempre é uma coisa boa, porém nesse caso, está aplicado de forma correta
    public abstract class DebitoConta
    {
        public string NumeroTransacao { get; set; }
        public abstract string Debitar(decimal valor, string conta);
        public string FormatarTransacao()
        {
            //mesmo q a classe seja abstrata, o metodo serve como base para todas as outras, significa que quem herdar é obrigado a usar o "Debitar" mas pode usar o FormatarTransacao como base (Muito Importante)
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890";
            var random = new Random();
            NumeroTransacao = new string(Enumerable.Repeat(chars, 15).Select(s => s[random.Next(s.Length)]).ToArray());

            //Numero de transacao formatado
            return NumeroTransacao;
        }
    }
}
