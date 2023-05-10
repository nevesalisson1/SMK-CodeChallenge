using SMK.Application.ViewModels;
using SMK.Domain.Interfaces.BusinessLogic;
using SMK.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK.Domain.Implementations
{
    public class CargueiroDomainService : ICargueiroDomainService
    {
        private readonly IFuctDomainService _fuctDomainService;

        public CargueiroDomainService(IFuctDomainService fuctDomainService)
        {
            _fuctDomainService = fuctDomainService;
        }

        public async Task RegistrarRetorno(RetornoCargueiro retorno)
        {
            var ehPermitido = RealizarChegagemPermissaoRetornoDeCargueiro();

            if (ehPermitido)
            {
                Data data = new Data();

                data.Ano = 3;
                data.Semana = 2;
                data.Mes = 4;

                retorno.Minerios = await _fuctDomainService.ObterMinerais(data);
            }
            else
            {

            }

            //return
            throw new NotImplementedException();
        }

        public async Task RegistrarSaida(SaidaCargueiro saida)
        {
            throw new NotImplementedException();
        }

        private bool RealizarChegagemPermissaoRetornoDeCargueiro()
        {


            return true;
        }
    }
}
