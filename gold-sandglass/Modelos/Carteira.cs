using System.ComponentModel.DataAnnotations;

namespace gold_sandglass.Modelos
{
    public class Carteira
    {
        public int Id { get; set; }
        [StringLength(20,ErrorMessage ="Nome da carteira vazio, favor preencher")]
        public string Nome { get; set; }
        public decimal Saldo { get; set; }
    }
}
