using System.ComponentModel.DataAnnotations;

namespace SMK.Infrastructure.Entities
{
    public class Cargueiro
    {
        [Key]
        public int CargueiroId { get; protected set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public uint Espaco { get; set; }
        [Required]
        public IList<MinerioCargueiro> MinerioCargueiros { get; set; }
        //public ICollection<Saida>? Saida { get; }
        //public ICollection<Retorno>? Retorno { get; }
    }
}
