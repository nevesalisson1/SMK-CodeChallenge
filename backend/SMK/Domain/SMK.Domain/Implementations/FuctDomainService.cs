using Microsoft.Extensions.Configuration;
using SMK.Domain.Interfaces;
using SMK.Domain.Models;
using System.Net.Http.Json;

namespace SMK.Domain.Implementations
{
    public class FuctDomainService : IFuctDomainService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public FuctDomainService(IConfiguration configuration)
        {
            //TODO Injecao de dependencia
            _configuration = configuration;
            _httpClient = new HttpClient();
        }

        public async Task<Minerios> ObterMinerais(Data data)
        {
            //TODO Finalizar Request
            await RequestMinerais();
            throw new NotImplementedException();
        }

        private async Task<dynamic> RequestMinerais()
        {
            try
            {
                //TODO Finalizar obtencao de dados
                var UriAPI = _configuration.GetValue<string>("UriFUCT");
                //dynamic dados = await _httpClient.GetFromJsonAsync<object>();

                //return dados;
                throw new NotImplementedException();
            }
            catch(Exception e)
            {
                throw new Exception("Erro não definido");
            }
        }
    }
}
