using System;
using System.Threading.Tasks;
using R6Tab.NET.Models;

namespace R6Tab.NET
{
    public interface IR6TabApi
    {
        Task<SearchResults> SearchByName(string playerName, Platform platform, string apiKey);

        Task<PlayerData> SearchById(Guid playerId, string apiKey);
    }
}
