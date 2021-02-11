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
            ITokenSerializerService serializerService,
            string tokenEndpointBaseAddress)
            : base(httpClient, anonymousCredentialsStoreManager, serializerService, tokenEndpointBaseAddress)
        {
            this.ClientConfiguration = configuration;
            this.anonymousCredentialsStoreManager = anonymousCredentialsStoreManager;
        }

        public TokenFlow TokenFlow => TokenFlow.AnonymousSession;
        
        protected override string BuildTokenRequestUri()
        {
            var requestUri = this.TokenEndpointBaseAddress+"?grant_type=client_credentials";
            if (!string.IsNullOrEmpty(this.ClientConfiguration.Scope))
            {
                requestUri += $"&scope={this.ClientConfiguration.Scope}";
            }

            if (!string.IsNullOrEmpty(this.anonymousCredentialsStoreManager.AnonymousId))
            {
                requestUri += $"&anonymous_id={this.anonymousCredentialsStoreManager.AnonymousId}";
            }
            return requestUri;
        }
    }
}