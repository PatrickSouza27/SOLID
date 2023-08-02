using SOLID.ISP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void EnviarEmail()
        {
            // Enviar Email para o Cliente
        }

        public void SalvarBanco()
        {
            // Insert no banco na tabela Cliente
        }

        public void ValidarDados()
        {
           // Valida os dados do cliente
        }
    }
}
