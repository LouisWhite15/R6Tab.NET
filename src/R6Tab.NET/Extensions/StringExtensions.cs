using System;
namespace R6Tab.NET.Extensions
{
    public static class StringExtensions
    {
        public static string AddApiKey(this string request, string apiKey)
        {
            return $"{request}{Constants.API_KEY_PARAM}{apiKey}";
        }
    }
}
