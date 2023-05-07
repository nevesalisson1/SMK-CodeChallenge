using Microsoft.Extensions.Configuration;
using SMK.Domain.HttpFactory;
using SMK.Domain.Interfaces;
using SMK.Domain.Models;
using System.Net.Http.Json;

namespace SMK.Domain.Implementations
{
    public class FuctDomainService : IFuctDomainService
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;

        public FuctDomainService(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Minerios> ObterMinerais(Data data)
        {
            var minerais = await RequestMinerais(data);
            return minerais;
        }

        private async Task<Minerios> RequestMinerais(Data data)
        {
            try
            {
                var urlApiRequest = _configuration.GetValue<string>("UrlApiFUCT");
                var path = ApiUrlConstants.UrlGetMinerais(urlApiRequest, data);

                var httpClient = _httpClientFactory.CreateClient();
                var request = new HttpRequestMessage(HttpMethod.Get, path);
                var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
                var responseContent = await response.Content.ReadFromJsonAsync<Minerios>();

                return responseContent;
            }
            catch(Exception e)
            {
                throw new Exception("Erro não definido");
            }
        }
    }
}
