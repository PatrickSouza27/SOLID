using SOLID.DIP.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.DIP.Solucao.Interfaces
{
    public class ClienteRepositoryEntityFramework : IClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            //Implementar uma forma de jogar no banco com o EntityFramework
        }
    }
}
