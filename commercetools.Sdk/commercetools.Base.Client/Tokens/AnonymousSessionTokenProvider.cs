using System;
using System.Net.Http;

namespace commercetools.Base.Client.Tokens
{
    public class AnonymousSessionTokenProvider : TokenProvider, ITokenProvider
    {
        private readonly IAnonymousCredentialsStoreManager anonymousCredentialsStoreManager;
        public AnonymousSessionTokenProvider(
            IClientConfiguration configuration,
            HttpClient httpClient,
            IAnonymousCredentialsStoreManager anonymousCredentialsStoreManager,
            ITokenSerializerService serializerService)
            : base(httpClient, anonymousCredentialsStoreManager, serializerService)
        {
            this.ClientConfiguration = configuration;
            this.anonymousCredentialsStoreManager = anonymousCredentialsStoreManager;
        }

        public TokenFlow TokenFlow => TokenFlow.AnonymousSession;

        public override HttpRequestMessage GetRequestMessage()
        {
            HttpRequestMessage request = new HttpRequestMessage();
            string requestUri = this.ClientConfiguration.AuthorizationBaseAddress + $"oauth/{this.ClientConfiguration.ProjectKey}/anonymous/token?grant_type=client_credentials";
            if (!string.IsNullOrEmpty(this.ClientConfiguration.Scope))
            {
                requestUri += $"&scope={this.ClientConfiguration.Scope}";
            }

            if (!string.IsNullOrEmpty(this.anonymousCredentialsStoreManager.AnonymousId))
            {
                requestUri += $"&anonymous_id={this.anonymousCredentialsStoreManager.AnonymousId}";
            }

            request.RequestUri = new Uri(requestUri);
            string credentials = $"{this.ClientConfiguration.ClientId}:{this.ClientConfiguration.ClientSecret}";
            request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(credentials)));
            request.Method = HttpMethod.Post;
            return request;
        }
    }
}