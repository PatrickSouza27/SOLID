using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void EnviarEmail()
        {
            // Produto não tem email, o que eu faço agora??
            throw new NotImplementedException("Esse metodo não está implementado");
            //você está obrigado essa classe utilizar um metodo que ele não usa, e vc n pode somente tirar, pois a interface é um contrato, e vc é obrigado utilizar
        }

        public void SalvarBanco()
        {
            // Insert tabela Produto
        }

        public void ValidarDados()
        {
            // Valida Valor
        }
    }
}
