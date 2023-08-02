namespace SOLID.DIP.Violacao
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
