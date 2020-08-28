using System;
using System.Net.Http;

namespace commercetools.Api.Client
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
    }
}
