using SMK.Domain.Interfaces;
using SMK.Domain.Models;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading;

namespace SMK.Domain.Implementations
{
    public class FuctDomainService : IFuctDomainService
    {
        private readonly HttpClient _httpClient;

        public FuctDomainService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Minerios> ObterMinerais(Data data)
        {
            await ProcessRepositoriesAsync();
            throw new NotImplementedException();
        }

        private async Task<dynamic> ProcessRepositoriesAsync()
        {
            
            try
            {
                dynamic x = await _httpClient.GetFromJsonAsync<object>("https://fuct-smk186-code-challenge.cblx.com.br/minerais?mes=3&ano=3000&semana=3");

                return x;
            }
            catch(Exception e)
            {
                throw new Exception("Erro não definido");
            }


        }
    }
}
