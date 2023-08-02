using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Solucao.Interfaces
{
    public interface ICadastro
    {
        // esses dois metodos é reutilizado em diferentes interfaces, então o ICadastro é uma interface ainda mais generica
        //você nesse caso está criando um padrão pra todas as classes ou interface que seja de cadastro
        void SalvarBanco();
        void ValidarDados();
    }
}
