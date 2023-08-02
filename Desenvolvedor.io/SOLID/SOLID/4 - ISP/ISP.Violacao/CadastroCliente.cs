﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP.Violacao
{
    public class CadastroCliente : ICadastro
    {
        public void EnviarEmail()
        {
            // Enviar Email para o Cliente
        }

        public void SalvarBanco()
        {
            // Insert na tabela Cliente
        }

        public void ValidarDados()
        {
            // Validar CPF, Email
        }
    }
}
