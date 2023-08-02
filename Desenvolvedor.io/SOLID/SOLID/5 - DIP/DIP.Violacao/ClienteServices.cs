

namespace SOLID.DIP.Violacao
{
    //Classe que Orquestra tudo isso
    //ainda dá para melhorar, mas já tira a responsabilidade da classe Cliente
    //todos os pilares do solid são para atender o SRT - "S"
    public class ClienteServices
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados Invalidos";
            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);
           EmailServices.Enviar("empresa@empresa.com", cliente.Email.EmailAddress, "Bem Vindo", "Parabens, Cliente Cadastrado com sucesso");
            return "Cliente Cadastrado com sucesso";
        }
    }
}
