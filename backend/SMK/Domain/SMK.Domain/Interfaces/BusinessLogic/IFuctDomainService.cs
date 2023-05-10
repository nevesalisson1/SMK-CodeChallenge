using SMK.Domain.Models;

namespace SMK.Domain.Interfaces.BusinessLogic
{
    public interface IFuctDomainService
    {
        public Task<Minerios> ObterMinerais(Data data);
    }
}
