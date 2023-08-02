using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Solucao.Interfaces
{
    public interface ICadastroProduto : ICadastro
    {
        void NumerarProduto();
    }
}
