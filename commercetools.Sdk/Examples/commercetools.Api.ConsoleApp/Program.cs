using System;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Api.Models.Errors;
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
                s => s.GetService<SerializerService>()
            );

            var serviceProvider = collection.BuildServiceProvider();
            var config = new ClientConfiguration()
            {
                ClientId = "",
                ClientSecret = "",
                ProjectKey = ""
            };
            var clientFactory = serviceProvider.GetService<IHttpClientFactory>();
            var client = ClientFactory.Create(
                clientName,
                config,
                clientFactory,
                serviceProvider.GetService<SerializerService>(),
                TokenProviderFactory.CreateClientCredentialsTokenProvider(config, clientFactory)
            );
            var project = await new ApiRoot(client)
                .WithProjectKey(config.ProjectKey)
                .Get()
                .ExecuteAsync();

            Console.WriteLine(project.Name);
        }
    }
}