using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using R6Tab.NET.Models;

namespace R6Tab.NET
{
    public class R6TabApi : IR6TabApi
    {
        private readonly HttpClient _httpClient;

        public R6TabApi()
        {
            _httpClient = HttpClientFactory.Create();
            _httpClient.BaseAddress = new Uri(Constants.API_BASE_URL);
        }

        public async Task<NameResults> GetPlayerWithNameAndPlatform(string playerName, Platform platform)
        {
            var requestUrl = Constants.API_URL_SEARCH + "?platform=" + platform.ToString().ToLower() + "&search=" + playerName;

            var response = await _httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<NameResults>(content);
        }
    }
}
