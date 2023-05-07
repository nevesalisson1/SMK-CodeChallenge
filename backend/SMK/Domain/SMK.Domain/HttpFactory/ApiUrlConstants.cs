using Microsoft.Extensions.Configuration;
using SMK.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK.Domain.HttpFactory
{
    public static class ApiUrlConstants
    {
        private static readonly string mineraisUrl = "/minerais";

        public static string UrlGetMinerais(string Url, Data data)
        {
            
            var path = Url + $"/{mineraisUrl}?mes={data.Mes}&ano={data.Ano}&semana={data.Semana}";

            return path;
        }
    }
}
