using SMK.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK.Application.ViewModels
{
    public class CadastroCargueiroViewModel
    {
        [Required]
        public string TipoCargueiro { get; set; }
        [Required]
        public DateTime Saida { get; set; }
        public DateTime? Retorno { get; set; }
        public MineriosViewModel? Minerios { get; set; }
    }
}
