using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }
        public string AdicionarCliente()
        {
            if (!Email.Contains("@"))
                return "Cliente com e-mail invalido";
            if (CPF.Length != 11)
                return "Cliente com CPF invalido";
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO [Cliente] (Nome, Email, Cpf, DataCadastro) VALUES (@Nome, @Email, @Cpf, @DataCadast)";

                cmd.Parameters.AddWithValue("Nome", Nome);
                cmd.Parameters.AddWithValue("Email", Email);
                cmd.Parameters.AddWithValue("Cpf", CPF);
                cmd.Parameters.AddWithValue("DataCadastro", DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            var mail = new MailMessage("empresa@empresa.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = true,
                Host = "smtp.google.com"
            };
            mail.Subject = "Bem vindo";
            mail.Body = "Parabens, vc está cadastrado";
            client.Send(mail);

            return "Cliente cadastrado com sucesso";
        }
        //existem varias violações da responsabilidade unica que está acontecendo nessa classe, persistencia, uso com a conexão do banco, não é obrigado a passar a connection string, não é obrigado a saber os parametros passado para colocar na tabela, não é obrigado a saber enviar o email

        //se a classe representa um cliente, ela tem que representar o Cliente
        //se ela persiste no banco, ela tem que ser um repositorio
        //se ela envia um email, ela tem que ser um serviço de envio de email

        //funciona? sim, mas se um dia uma connection string, colunas do banco ou outra coisa mudar, ela vai afetar o cliente como um todo

        //mas o maior problema é em questão teste, se a classe falhar, como vc vai saber, oque falhou? imagina q retorne "Falha ao cadastrar", como vc vai saber onde exatamente falhou?, então não é somente sobre qualidade, é como testar e garantir
    }
}
