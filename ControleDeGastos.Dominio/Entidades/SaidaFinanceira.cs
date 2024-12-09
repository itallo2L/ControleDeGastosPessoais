namespace ControleDeGastos.Dominio.Entidades
{
    public class SaidaFinanceira
    {
        public int Id { get; set; }
        public double ValorGasto { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
    }
}