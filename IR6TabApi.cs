using System;
using System.Threading.Tasks;
using R6Tab.NET.Models;

namespace R6Tab.NET
{
    public interface IR6TabApi
    {
        Task<SearchResults> SearchByName(string playerName, Platform platform);

        Task<PlayerData> SearchById(Guid playerId);
    }
}
