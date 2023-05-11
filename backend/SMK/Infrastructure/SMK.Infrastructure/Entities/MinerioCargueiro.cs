using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK.Infrastructure.Entities
{
    public class MinerioCargueiro
    {
        public int CargueiroId { get; set; }
        public Cargueiro Cargueiro { get; set; }

        public int MinerioId { get; set; }
        public Minerio Minerio { get; set; }
    }
}
