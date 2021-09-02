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

        protected override string BuildTokenRequestBody()
        {
            var body = "grant_type=client_credentials";
            var scope = this.ClientConfiguration.Scope;
            var anonymousId = this.anonymousCredentialsStoreManager.AnonymousId;
            if (!string.IsNullOrEmpty(scope))
            {
                body += $"&scope={scope}";
            }
            if (!string.IsNullOrEmpty(anonymousId))
            {
                body += $"&anonymous_id={anonymousId}";
            }

            return body;
        }
    }
}