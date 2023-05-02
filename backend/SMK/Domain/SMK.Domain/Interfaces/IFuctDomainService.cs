using SMK.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK.Domain.Interfaces
{
    public interface IFuctDomainService
    {
        public Task<Minerios> ObterMinerais(Data data);
    }
}
