using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Violacao
{
    public class CalculoArea
    {
        private static void ObterAreaRetangulo(Retangulo area)
        {
            Console.WriteLine(area.Altura + " * " + area.Largura);
            Console.WriteLine(area.Area);
        }
        public static void Calcular()
        {
            //se um quadrado não pode ser substuido por um retangulo, significa que o quadrado não pode ser herdado
            var quad = new Quadrado()
            {
                Altura = 10,
                Largura = 5
            };
            ObterAreaRetangulo(quad);
        }
    }

}
