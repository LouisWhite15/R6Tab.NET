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

        public async Task<SearchResults> SearchByName(string playerName, Platform platform)
        {
            var requestUrl = Constants.API_URL_SEARCH + platform.ToString() + "/" + playerName;

            var response = await _httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SearchResults>(content);
        }

        public async Task<PlayerData> SearchById(Guid playerId)
        {
            var requestUrl = Constants.API_URL_PLAYER + "/" + playerId.ToString();

            var response = await _httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PlayerData>(content);
        }
    }
}
