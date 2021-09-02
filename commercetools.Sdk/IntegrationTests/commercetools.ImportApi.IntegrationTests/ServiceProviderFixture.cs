using commercetools.Base.Client;
using commercetools.Sdk.ImportApi;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace commercetools.ImportApi.IntegrationTests
{
    public class ServiceProviderFixture
    {
        private readonly ServiceProvider serviceProvider;
        private readonly IConfiguration configuration;

        public ServiceProviderFixture()
        {
            var services = new ServiceCollection();

            this.configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.Development.json", true).
                AddEnvironmentVariables().
                AddUserSecrets<ServiceProviderFixture>().
                AddEnvironmentVariables("CTP_").
                Build();

            services.UseCommercetoolsImportApi(configuration, "ImportClient");
            this.serviceProvider = services.BuildServiceProvider();

            //set default ProjectKey
            var clientConfiguration = this.GetClientConfiguration("ImportClient");
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
