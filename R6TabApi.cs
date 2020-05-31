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

        public async Task<SearchResults> SearchByName(string playerName, Platform platform, string apiKey)
        {
            var requestUrl = Constants.API_URL_SEARCH + platform.ToString() + "/" + playerName + Constants.API_KEY_PARAM + apiKey;

            var response = await _httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SearchResults>(content);
        }

        public async Task<PlayerData> SearchById(Guid playerId, string apiKey)
        {
            var requestUrl = Constants.API_URL_PLAYER + playerId.ToString() + Constants.API_KEY_PARAM + apiKey;

            var response = await _httpClient.GetAsync(requestUrl);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<PlayerData>(content);
        }

        public async Task UpdatePlayerDataById(Guid playerId, string apiKey)
        {
            var requestUrl = Constants.API_URL_UPDATE + playerId.ToString() + Constants.API_KEY_PARAM + apiKey;

            var response = await _httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
        }
    }
}
