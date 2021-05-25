using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using commercetools.Base.Client.Tokens;

namespace commercetools.Base.Client
{
    public class TokenProviderFactory
    {
        public static ITokenProvider CreateClientCredentialsTokenProvider(
            IClientConfiguration configuration,
            IHttpClientFactory factory,
            ITokenStoreManager tokenStoreManager = null,
            string tokenEndpointBaseAddress = null)
        {
            var tokenStore = tokenStoreManager ?? new InMemoryTokenStoreManager();
            return Create(TokenFlow.ClientCredentials, configuration, factory, tokenEndpointBaseAddress, tokenStore);
        }

        public static ITokenProvider CreatePasswordTokenProvider(
            IClientConfiguration configuration,
            IHttpClientFactory factory,
            IUserCredentialsStoreManager userCredentials,
            string tokenEndpointBaseAddress = null)
        {
            return Create(TokenFlow.Password, configuration, factory, tokenEndpointBaseAddress, null, userCredentials);
        }

        public static ITokenProvider CreateAnonymousSessionTokenProvider(
            IClientConfiguration configuration,
            IHttpClientFactory factory,
            IAnonymousCredentialsStoreManager anonymousCredentials,
            string tokenEndpointBaseAddress = null)
        {
            return Create(TokenFlow.AnonymousSession, configuration, factory, tokenEndpointBaseAddress, null, null, anonymousCredentials);
        }

        private static ITokenProvider Create(
            TokenFlow tokenFlow,
            IClientConfiguration configuration,
            IHttpClientFactory factory,
            string tokenEndpointBaseAddress = null,
            ITokenStoreManager tokenStoreManager = null,
            IUserCredentialsStoreManager userCredentials = null,
            IAnonymousCredentialsStoreManager anonymousCredentials = null
            )
        {
            Validator.ValidateObject(configuration, new ValidationContext(configuration), true);
            ITokenProvider provider = null;
            var authClient = factory.CreateClient(DefaultClientNames.Authorization);
            var serializerService = new TokenSerializerService();
            var tokenEndpointUrl = tokenEndpointBaseAddress ??
                                   GetDefaultTokenEndpointUrl(configuration, tokenFlow);
            switch (tokenFlow)
            {
                case TokenFlow.Password:
                    provider = new PasswordTokenProvider(configuration, authClient, userCredentials, serializerService, tokenEndpointUrl);
                    break;
                case TokenFlow.AnonymousSession:
                    provider = new AnonymousSessionTokenProvider(configuration, authClient, anonymousCredentials, serializerService, tokenEndpointUrl);
                    break;
                default:
                    provider = new ClientCredentialsTokenProvider(configuration, authClient, tokenStoreManager, serializerService, tokenEndpointUrl);
                    break;
            }

            return provider;
        }
        
        private static string GetDefaultTokenEndpointUrl(IClientConfiguration configuration, TokenFlow tokenFlow)
        {
            var tokenUrl = "";
            switch (tokenFlow)
            {
                case TokenFlow.Password:
                    tokenUrl = configuration.AuthorizationBaseAddress +
                               $"oauth/{configuration.ProjectKey}/customers/token";
                    break;
                case TokenFlow.AnonymousSession:
                    tokenUrl = configuration.AuthorizationBaseAddress +
                               $"oauth/{configuration.ProjectKey}/anonymous/token";
                    break;
                default:
                    tokenUrl = configuration.AuthorizationBaseAddress + $"oauth/token";
                    break;
            }

            return tokenUrl;
        }
    }
}