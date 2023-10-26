namespace gold_sandglass.Modelos
{
    public class Movimentacao
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public bool Pagamento { get; set; }

        public int UsuarioRelatorId { get; set; }
        public int Usuario { get; set; }
    }
}
