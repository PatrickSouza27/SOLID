using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.DIP.Solucao.Interfaces
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Cpf CPF { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Validar() => Email.Validar() && CPF.Validar();
    }
}
