using SMK.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK.Application.ViewModels
{
    public class SaidaCargueiroViewModel
    {
        [Required]
        public string TipoCargueiro { get; set; }
        [Required]
        public DateTime SaidaDateTime { get; set; }
    }
}
