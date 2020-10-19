using System;
using System.Linq;
using System.Net.Http;

namespace commercetools.Base.Client
{
    public static class ClientExtensions
    {
        public static void AddHeaders(
            this HttpRequestMessage requestMessage
            , ApiHttpHeaders addedHeaders)
        {
            foreach (var header in addedHeaders.Headers)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }
        }
        
        public static string ToSnakeCase(this string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
    }
}
