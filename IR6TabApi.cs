using System.Threading.Tasks;
using R6Tab.NET.Models;

namespace R6Tab.NET
{
    public interface IR6TabApi
    {
        Task<NameResults> GetPlayerWithNameAndPlatform(string playerName, Platform platform);
    }
}
