using SOLID.Violao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if(tipoConta == TipoConta.Poupanca)
            {
                //Debito Conta Corrente
            }
            if(tipoConta == TipoConta.Corrente)
            {
                //Valida Aniversário da Conta
                //Debita Conta Poupança
            }
        }
        //Qual o problema dessa classe?
        //ela não está fechada para modificação
        //imagina que surge a conta investimento, vc colocaria "investimento" de enum e colocaria mais um if nessa classe, fazendo isso, vc muda a forma da classe trabalhar podendo causar algum problema, prefira nunca mexer em uma classe que esteja funcionando, e sim faça uma extensão
    }
}
