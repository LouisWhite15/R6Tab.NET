using System;
using System.Threading.Tasks;
using R6Tab.NET.Models;

namespace R6Tab.NET
{
    public interface IR6TabApi
    {
        Task<NameResults> GetPlayerByNameAndPlatform(string playerName, Platform platform);

        Task<PlayerDataResults> GetPlayerById(Guid playerId);
    }
}
