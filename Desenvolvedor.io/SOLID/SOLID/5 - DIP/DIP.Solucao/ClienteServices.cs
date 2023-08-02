using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP.DIP.Solucao.Interfaces
{
    public class ClienteServices : IClienteServices
    {
        private readonly IEmailServices _emailServices;
        private readonly IClienteRepository _clienteRepository;

        //é como se, eu como ClienteService (Serviço de Cliente) não sou obrigado a saber como criar uma instancia de serviço de email e serviço de banco, eu preciso usar, mas n sou obrigado a criar os objetos
        //o que quero que aconteça é que quem for criar o ClienteService passe já o EmailService e o ClienteRepository já criados dentro do construtor
        //vc injetou uma classe dentro do construtor, e ela que está trabalhando dentro dessa sua classe e não sua classe tendo que criar
        public ClienteServices(IEmailServices emailServices, IClienteRepository clienteRepository)
        {
            _emailServices = emailServices;
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados Invalidos";

            _clienteRepository.AdicionarCliente(cliente);
            _emailServices.Enviar("empresa@empresa.com", cliente.Email.EmailAddress, "Bem Vindo", "Parabens, Cliente Cadastrado com sucesso");

            return "Cliente Cadastrado com sucesso";
        }
    }
    public class Testing
    {
        public static void Main(string[] args)
        {
            //vc pode passar diferentes tipos de ClienteRepository por exemplo, que siga o contrato
            var resp = new ClienteServices(new EmailServices(), new ClienteRepository());
            Console.WriteLine(resp);

            //vai sempre precisar fazer isso para criar a classe? não, ai vai entrar um outro jeito que é, ter um container de injeção de dependencia, quando vc criar um cliente service, ele já vai te dar uma instancia pronta
            var resp2 = new ClienteServices(new EmailServices(), new ClienteRepositoryEntityFramework());
            Console.WriteLine(resp2);

            var resp3 = new ClienteServices(new EmailServices(), new ClienteRepositoryDapper());
            Console.WriteLine(resp3);
            //todos que usar o contrato do Repositorio, e implementer a forma que bem entender o(os) metodos podem usar, nesse caso, ele n sabe como será feito, ele só sabe o metodo obrigatorio no contrato, então ele irá chamar
            //exemplo, calcular taxas: taxabrasil : taxas, taxaEUA : taxas com metodo calcular retornando um double
            //a cliente services só muda se o contrato mudar, fora isso, ele orquestra o banco com a classe Testing
        }
    }
}
