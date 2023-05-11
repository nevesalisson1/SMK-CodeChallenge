using System.ComponentModel.DataAnnotations;

namespace SMK.Infrastructure.Entities
{
    public class Minerio
    {
        [Key]
        public int MinerioId { get; protected set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public double PrecoPorKg { get; set; }
        [Required]
        public IList<MinerioCargueiro> MinerioCargueiros { get; }
    }
}
