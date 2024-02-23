using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using commercetools.Base.Client;
using commercetools.Base.Client.Domain;
using commercetools.Base.Client.Tokens;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Xunit.Abstractions;

namespace commercetools.Sdk.Api.Tests
{
    public class TokenProviderTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public TokenProviderTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        class TestTokenStoreManager : ITokenStoreManager
        {
            public Token Token { get; set; }
            public void ClearToken()
            {
                throw new System.NotImplementedException();
            }
        }

        class TestHandler : HttpMessageHandler
        {
            public int Called { get; private set; }
            public String lastUrl { get; private set; }

            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                Called++;
                lastUrl = request.RequestUri.ToString();
                return await Task.Run(() => CannedResponse(), cancellationToken).ConfigureAwait(false);
            }

            private HttpResponseMessage CannedResponse()
            {
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("{\"access_token\": \"abc\", \"expires_in\": 3600}")
                };
            }
        }

        [Fact]
        public async void expiredTokens()
        {
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.json", true).
                Build();

            var s = new ServiceCollection();
            var p = s.BuildServiceProvider();

            var factory = p.GetService<IHttpClientFactory>();

            var tokenManager = new InMemoryTokenStoreManager();
            var testHandler = new TestHandler();
            var provider = new ClientCredentialsTokenProvider(
                configuration.GetSection("Test1").Get<ClientConfiguration>(),
                new HttpClient(testHandler),
                tokenManager,
                new TokenSerializerService(),
                "http://auth.commercetools.com/oauth/token"
            );

            var token = await provider.GetToken();

            Assert.NotNull(token);
            Assert.Equal(1, testHandler.Called);
            Assert.Equal("http://auth.commercetools.com/oauth/token", testHandler.lastUrl);
            token = await provider.GetToken();
            Assert.Equal(1, testHandler.Called);

            tokenManager.Token.ExpiresIn = 1;
            token = await provider.GetToken();
            Assert.Equal(2, testHandler.Called);
            Assert.Equal("http://auth.commercetools.com/oauth/token", testHandler.lastUrl);


            var r = new Random();
            var taskList = new Task[1000000];

            for (int i = 0; i < 1000000; i++)
            {
                tokenManager.Token.ExpiresIn = r.Next(500);
                taskList[i] = provider.GetToken();
            }
            Task.WaitAll(taskList, TimeSpan.FromSeconds(3));

            token = await provider.GetToken();
            Assert.NotNull(token);
        }
    }
}