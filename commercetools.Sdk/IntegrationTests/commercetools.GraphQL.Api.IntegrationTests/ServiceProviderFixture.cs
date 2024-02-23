using commercetools.Sdk.Api.Models.Errors;
using commercetools.Base.Client;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace commercetools.GraphQL.Api.IntegrationTests
{
    public class ServiceProviderFixture
    {
        private readonly ServiceProvider serviceProvider;
        private readonly IConfiguration configuration;

        public ServiceProviderFixture()
        {
            var services = new ServiceCollection();

            //services.AddLogging(configure => configure.AddConsole());
            this.configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.Development.json", true).
                AddEnvironmentVariables().
                AddUserSecrets<ServiceProviderFixture>().
                AddEnvironmentVariables("CTP_").
                Build();
            var useStreamClient = Enum.Parse<ClientType>(configuration.GetValue("ClientType", "String")) == ClientType.Stream;

            services.UseCommercetoolsApi(configuration, "Client", options: new ClientOptions { ReadResponseAsStream = useStreamClient });
            services.AddLogging(c => c.AddProvider(new InMemoryLoggerProvider()));
            services.SetupClient(
                "MeClient",
                errorTypeMapper => typeof(ErrorResponse),
                s => s.GetService<IApiSerializerService>()
            );
            this.serviceProvider = services.BuildServiceProvider();

            //set default ProjectKey
            var clientConfiguration = this.GetClientConfiguration("Client");
            GenericFixture.DefaultProjectKey = clientConfiguration.ProjectKey;
        }

        public T GetService<T>()
        {
            return this.serviceProvider.GetService<T>();
        }

        public IClientConfiguration GetClientConfiguration(string name)
        {
            return this.configuration.GetSection(name).Get<ClientConfiguration>();
        }
    }
}
