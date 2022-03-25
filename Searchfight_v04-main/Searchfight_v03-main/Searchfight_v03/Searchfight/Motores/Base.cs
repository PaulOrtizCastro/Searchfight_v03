using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Searchfight.Motores
{
    public class Base
    {
        private readonly HttpClient _httpClient;
        public Base()
        {
            _httpClient = new HttpClient();
        }
        public JObject GetResponse(string url)
        {
            try
            {
                _httpClient.Timeout = TimeSpan.FromSeconds(3);
                var data = _httpClient.GetStringAsync(url).Result;
                return JObject.Parse(data);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                return null;
                //throw;
            }
        }
        public void AddHeader(string key, string value)
        {
            _httpClient.DefaultRequestHeaders.Add(key, value);
        }
        public string obtenerLlave(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
