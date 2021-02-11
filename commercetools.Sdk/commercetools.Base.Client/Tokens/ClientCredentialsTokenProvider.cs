using System;
using System.Net.Http;

namespace commercetools.Base.Client.Tokens
{
    public class ClientCredentialsTokenProvider : TokenProvider, ITokenProvider
    {
        public ClientCredentialsTokenProvider(
            IClientConfiguration configuration,
            HttpClient httpClient,
            ITokenStoreManager tokenStoreManager,
            ITokenSerializerService serializerService,
            string tokenEndpointBaseAddress)
            : base(httpClient, tokenStoreManager, serializerService, tokenEndpointBaseAddress)
        {
            ClientConfiguration = configuration;
        }

        public TokenFlow TokenFlow => TokenFlow.ClientCredentials;
    }
}
