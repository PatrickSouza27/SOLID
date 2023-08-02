using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Solucao
{
    public abstract class Paralelogramo
    {
        //Aqui estou tbm usando um pouco de OPC, pois fecho ele para motificação e abro para extensão
        //fazer herança n é errado, errado é fazer uma herança errada, vc fazer uma herança que deforme a superclasse
        //o Retangulo é um Paralelogramo
        //o Quadrado é um Paralelogramo
        protected Paralelogramo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }
        public double Altura { get; private set; }
        public double Largura { get; private set; }
        public double Area { get { return Altura * Largura; } }
    }
}
