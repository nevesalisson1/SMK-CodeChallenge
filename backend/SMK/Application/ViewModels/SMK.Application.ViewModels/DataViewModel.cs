using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK.Application.ViewModels
{
    public class DataViewModel
    {
        [Required]
        public uint Semana { get; set; }
        [Required]
        public uint Mes { get; set; }
        [Required]
        public uint Ano { get; set; }
    }
}
