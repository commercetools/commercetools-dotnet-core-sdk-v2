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
            ITokenSerializerService serializerService)
            : base(httpClient, tokenStoreManager, serializerService)
        {
            ClientConfiguration = configuration;
        }

        public TokenFlow TokenFlow => TokenFlow.ClientCredentials;

        public override HttpRequestMessage GetRequestMessage()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            string requestUri = this.ClientConfiguration.AuthorizationBaseAddress + "oauth/token?grant_type=client_credentials";
            if (!string.IsNullOrEmpty(this.ClientConfiguration.Scope))
            {
                requestUri += $"&scope={this.ClientConfiguration.Scope}";
            }

            request.RequestUri = new Uri(requestUri);
            string credentials = $"{this.ClientConfiguration.ClientId}:{this.ClientConfiguration.ClientSecret}";
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentials)));
            request.Method = HttpMethod.Post;
            return request;
        }
    }
}
