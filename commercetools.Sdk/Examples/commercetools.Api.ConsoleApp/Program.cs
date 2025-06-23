using System;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Sdk.Api.Models.Errors;
using commercetools.Base.Client;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Client;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.Api.ConsoleApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var clientName = "test";
            var collection = new ServiceCollection();
            collection.UseCommercetoolsApiSerialization();
            collection.AddLogging();
            collection.SetupClient(
                clientName,
                errorTypeMapper => typeof(ErrorResponse),
                s => s.GetService<IApiSerializerService>()
            );

            var serviceProvider = collection.BuildServiceProvider();
            var config = new ClientConfiguration()
            {
                ClientId = "",
                ClientSecret = "",
                ProjectKey = "",
                ApiBaseAddress = "https://api.europe-west1.gcp.commercetools.com/",
                AuthorizationBaseAddress = "https://auth.europe-west1.gcp.commercetools.com/",
            };
            var clientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var client = new ClientBuilder()
            {
                ClientConfiguration = config,
                ClientName = clientName,
                TokenProvider = TokenProviderFactory.CreateClientCredentialsTokenProvider(config, clientFactory),
                SerializerService = serviceProvider.GetService<IApiSerializerService>(),
                HttpClient = clientFactory.CreateClient(clientName)
            }.Build();

            var project = await new ApiRoot(client)
                .WithProjectKey(config.ProjectKey)
                .Get()
                .ExecuteAsync();

            Console.WriteLine(project.Name);
        }
    }
}