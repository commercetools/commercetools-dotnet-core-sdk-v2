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

        protected override string BuildTokenRequestUri()
        {
            var requestUri = this.TokenEndpointBaseAddress+"?grant_type=password";
            requestUri += $"&username={this.userCredentialsManager.Username}";
            requestUri += $"&password={this.userCredentialsManager.Password}";
            if (!string.IsNullOrEmpty(this.ClientConfiguration.Scope))
            {
                requestUri += $"&scope={this.ClientConfiguration.Scope}";
            }

            return requestUri;
        }
    }
}
