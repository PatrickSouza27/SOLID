namespace SOLID.Solucao
{
    public class Email
    {
        public string EmailAddress { get; set; }
        public bool Validar()=> EmailAddress.Contains("@") && EmailAddress is not null;
    }
}