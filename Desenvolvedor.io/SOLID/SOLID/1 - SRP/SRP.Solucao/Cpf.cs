namespace SOLID.Solucao
{
    public class Cpf
    {
        public int Numero { get; set; }
        public bool Validar()=> Numero.Equals(0);
    }
}