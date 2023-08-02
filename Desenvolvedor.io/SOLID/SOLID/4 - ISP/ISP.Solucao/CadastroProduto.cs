using SOLID.ISP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Solucao
{
    public class CadastroProduto : ICadastroProduto
    {
        public void NumerarProduto()
        {
            // Cria uma numeração para o Produto
        }

        public void SalvarBanco()
        {
            // INSERT produto na tabela Produto
        }

        public void ValidarDados()
        {
            // Valida dados Produtos
        }
    }
}
