namespace Sabore.Models
{
    public class Produto
    {
        public Guid Guid { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public string? Imagem { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public float? Estoque { get; set; }
        public float? Desconto { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public DateTime? DataAlteracao { get; set; }
    }
}
