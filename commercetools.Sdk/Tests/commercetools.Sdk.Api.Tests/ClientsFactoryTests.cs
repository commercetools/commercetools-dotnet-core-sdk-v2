using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using commercetools.Base.Client;
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
        public void TestClientConfigValidation()
        {
            //arrange
            var s = new ServiceCollection();
            s.UseCommercetoolsApiSerialization();
            var p = s.BuildServiceProvider();
            var serializerService = p.GetService<SerializerService>();
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
    }
}