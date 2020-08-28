using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using commercetools.Sdk.DependencyInjection;
using commercetools.Sdk.HttpApi;
using commercetools.Sdk.HttpApi.Tokens;

namespace CodeGenerated.Tests
{
    public class ClientFixture
    {
        private readonly ServiceProvider serviceProvider;
        private readonly IConfiguration configuration;

        public ClientFixture()
        {
            var services = new ServiceCollection();

            //services.AddLogging(configure => configure.AddConsole());
            this.configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.Development.json", true).
                AddEnvironmentVariables().
                AddUserSecrets<ClientFixture>().
                Build();

            services.UseCommercetools(configuration, "Client", TokenFlow.ClientCredentials);
            this.serviceProvider = services.BuildServiceProvider();
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
