namespace ControleDeGastos.Dominio.Entidades
{
    public class EntradaFinanceira
    {
        public int Id { get; set; }
        public double ValorRecebido { get; set; }
        public double GastosEssenciais { get; set; }
        public double GastosOpcionais { get; set; }
        public double Investimentos { get; set; }
    }
}