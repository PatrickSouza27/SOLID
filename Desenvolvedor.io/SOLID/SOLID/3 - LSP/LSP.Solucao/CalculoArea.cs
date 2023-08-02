using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Solucao
{
    public class CalculoArea
    {
        private static void ObterAreaParalelogramo(Paralelogramo area)
        {
            Console.WriteLine(area.Altura + " * " + area.Largura);
            Console.WriteLine(area.Area);
        }
        public static void Calcular()
        {
            //se um quadrado não pode ser substuido por um retangulo, significa que o quadrado não pode ser herdado
            //quando executar, ele ira aparecer a excessão do Quadrado, pois, os lados dos quadrado precisam ser iguais
            // var quad = new Quadrado(5, 5);  // aqui funcionaria  //25
            var quad = new Quadrado(10, 5);
            var ret = new Retangulo(10, 5);  // 50
            ObterAreaParalelogramo(quad);
            ObterAreaParalelogramo(ret);
        }
    }
}
