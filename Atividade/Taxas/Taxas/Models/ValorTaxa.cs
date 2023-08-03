namespace Taxas.Models
{
    public class ValorTaxa
    {
        public double Valor { get; set; }
        public ValorTaxa() { }

        public ValorTaxa(double valor)
         => Valor = valor;
        
        public bool VerificaValor() => Valor < 0;
        public override string ToString() => "R$ " + Valor.ToString("F2");

    }
}
