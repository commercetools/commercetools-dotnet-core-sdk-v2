using System;
using System.ComponentModel.DataAnnotations;
using commercetools.Base.Client;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace commercetools.Api.Tests
{
    public class ClientsFactoryTests
    {
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