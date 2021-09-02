using System;
using System.Net.Http;

namespace commercetools.Base.Client.Tokens
{
    public class PasswordTokenProvider : TokenProvider, ITokenProvider
    {
        private readonly IUserCredentialsStoreManager userCredentialsManager;
        public PasswordTokenProvider(
            IClientConfiguration configuration,
            HttpClient httpClient,
            IUserCredentialsStoreManager userCredentialsStoreManager,
            ITokenSerializerService serializerService, string tokenEndpointBaseAddress)
            : base(httpClient, userCredentialsStoreManager, serializerService, tokenEndpointBaseAddress)
        {
            this.ClientConfiguration = configuration;
            this.userCredentialsManager = userCredentialsStoreManager;
        }

        public TokenFlow TokenFlow => TokenFlow.Password;

        protected override string BuildTokenRequestBody()
        {
            var body = "grant_type=password";
            var scope = this.ClientConfiguration.Scope;
            body += $"&username={this.userCredentialsManager.Username}";
            body += $"&password={this.userCredentialsManager.Password}";
            if (!string.IsNullOrEmpty(scope))
            {
                body += $"&scope={scope}";
            }

            return body;
        }
    }
}
