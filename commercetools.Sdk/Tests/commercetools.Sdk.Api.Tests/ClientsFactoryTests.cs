using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Client.Domain;
using commercetools.Base.Client.Middlewares;
using commercetools.Base.Client.Tokens;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Sdk.Api.Tests
{
    public class ClientsFactoryTests
    {
        [Fact]
        public void TestProjectApiRoots()
        {
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.json", true).
                Build();

            var clients = new List<string>()
            {
                "Test1",
                "Test2"
            };

            var s = new ServiceCollection();
            s.UseCommercetoolsApi(configuration, clients);

            var p = s.BuildServiceProvider();
            var root = p.GetServices<ProjectApiRoot>();

            Assert.Equal("test-1", root.First(apiRoot => apiRoot.ProjectKey == "test-1").ProjectKey);
            Assert.Equal("test-2", root.First(apiRoot => apiRoot.ProjectKey == "test-2").ProjectKey);
        }

        [Fact]
        public void TestUserAgent()
        {
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.json", true).
                Build();

            var s = new ServiceCollection();
            s.UseCommercetoolsApi(configuration, "Test1");

            var p = s.BuildServiceProvider();
            var userAgentProvider = p.GetService<IUserAgentProvider>();
            var userAgent = userAgentProvider.UserAgent;
            Assert.StartsWith("commercetools-sdk-dotnet-v2/", userAgent);

            var factory = p.GetService<IHttpClientFactory>();
            var httpClient = factory.CreateClient("Test1");
            var agent = httpClient.DefaultRequestHeaders.UserAgent.First();
            Assert.Equal("commercetools-sdk-dotnet-v2", agent.Product.Name);
        }

        [Fact]
        public void TestClientConfigValidation()
        {
            //arrange
            var s = new ServiceCollection();
            s.UseCommercetoolsApiSerialization();
            var p = s.BuildServiceProvider();
            var serializerService = p.GetService<IApiSerializerService>();
            var clientConfig = new ClientConfiguration
            {
                ClientId = "ClientId",
                ClientSecret = "ClientSecret",
                ProjectKey = "test",
                ApiBaseAddress = "https://api.europe-west1.gcp.commercetools.com",
                AuthorizationBaseAddress = "https://auth.europe-west1.gcp.commercetools.com/"
            };

            //act
            Exception validationEx = null;
            try
            {
                var tokenProvider = TokenProviderFactory
                    .CreateClientCredentialsTokenProvider(clientConfig, null);

                ClientFactory.Create("test", clientConfig, null, serializerService, tokenProvider);
            }
            catch (Exception e)
            {
                validationEx = e;
            }

            //assert
            Assert.NotNull(validationEx);
            Assert.IsType<ValidationException>(validationEx);
        }

        [Fact]
        public void ExistingToken()
        {
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.json", true).
                Build();

            var s = new ServiceCollection();
            s.UseCommercetoolsApiSerialization();

            s.UseCommercetoolsApi(configuration, "Test1", (clientName, config, serviceProvider) => new ExistingTokenProvider(new Token() { AccessToken = "abc" }));
            var p = s.BuildServiceProvider();
            var client = p.GetService<IClient>();
            Assert.IsAssignableFrom<IClient>(client);
        }

        private class ExistingTokenProvider : ITokenProvider
        {
            public Token Token { get; }

            private IClientConfiguration _configuration { get; }
            public ExistingTokenProvider(Token token, IClientConfiguration configuration = null)
            {
                Token = token;
                _configuration = configuration ?? new ClientConfiguration();
            }

            public TokenFlow TokenFlow => TokenFlow.ClientCredentials;
            public IClientConfiguration ClientConfiguration { get => _configuration; set => throw new InvalidOperationException("client configuration is readonly"); }

            public async Task<Token> GetToken()
            {
                return await Task.FromResult(Token);
            }
        }
    }
}