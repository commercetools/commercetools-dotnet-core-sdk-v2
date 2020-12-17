using System;
using System.Linq;
using System.Net.Http;

namespace commercetools.Base.Client
{
    public static class ClientExtensions
    {
        public static ApiHttpHeaders GetHeaders(this HttpRequestMessage requestMessage)
        {
            var headers = new ApiHttpHeaders();
            foreach (var header in requestMessage.Headers)
            {
                headers.AddHeader(header.Key, header.Value.ToString());
            }

            return headers;
        }
        
        public static void AddHeaders(
            this HttpRequestMessage requestMessage
            , ApiHttpHeaders addedHeaders)
        {
            foreach (var header in addedHeaders.Headers)
            {
                requestMessage.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }
        }
        
        public static string ToSnakeCase(this string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
    }
}
