using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Solucao
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado(int altura, int largura) : base(altura, largura)
        {
            //n permitindo que os lados seja diferentes
            if (!altura.Equals(largura))
                throw new ArgumentException("Os Dois Lados do quadrado precisam ser iguais");
        }
    }
}
