namespace SOLID.DIP.DIP.Solucao.Interfaces
{
    public class Email
    {
        public string EmailAddress { get; set; }
        public bool Validar()=> EmailAddress.Contains("@") && EmailAddress is not null;
    }
}