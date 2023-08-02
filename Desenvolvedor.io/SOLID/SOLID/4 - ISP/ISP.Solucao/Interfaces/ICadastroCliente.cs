using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Solucao.Interfaces
{
    public interface ICadastroCliente : ICadastro
    {
        //ICadastroCliente herda os metodos de ICadastro q são obrigado a implementação em uma classe que usar ela
        void EnviarEmail();
    }
}
