using SMK.Application.ViewModels;

namespace SMK.Domain.Interfaces.BusinessLogic
{
    public interface ICargueiroDomainService
    {
        public Task RegistrarSaida(SaidaCargueiro saida);
        public Task RegistrarRetorno(RetornoCargueiro retorno);
    }
}
