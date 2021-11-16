using System;
using commercetools.Sdk.HttpApi;
using commercetools.Sdk.HttpApi.Tokens;
using commercetools.Sdk.V2Compat;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SimpleInjector;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace commercetools.Sdk.BCTest
{
    public class ServiceProviderFixture
    {
        public readonly Guid TestId;
        public IServiceProvider ServiceProvider { get; private set; }
        public IConfiguration Configuration { get; private set; }

        public ServiceProviderFixture(IMessageSink diagnosticMessageSink)
        {
            this.TestId = Guid.NewGuid();
            this.Configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.test.Development.json", true).
                // https://www.jerriepelser.com/blog/aspnet-core-no-more-worries-about-checking-in-secrets/
                AddUserSecrets<ServiceProviderFixture>().
                AddEnvironmentVariables("CTP_").
                Build();

            var containerType = Enum.Parse<ContainerType>(Configuration.GetValue("Container", "BuiltIn"));
            diagnosticMessageSink.OnMessage(new DiagnosticMessage("Use container {0}", containerType.ToString()));
            switch (containerType)
            {
                case ContainerType.BuiltIn:
                    var services = new ServiceCollection();
                    services.UseCommercetools(Configuration, "Client", TokenFlow.ClientCredentials);
                    services.AddLogging(c => c.AddProvider(new InMemoryLoggerProvider()));
                    services.UseCommercetoolsCompatLayer();
                    this.ServiceProvider = services.BuildServiceProvider();
                    break;
                case ContainerType.SimpleInjector:
                    var container = new Container();
                    container.UseCommercetools(Configuration, "Client", TokenFlow.ClientCredentials);
                    container.Verify();
                    this.ServiceProvider = container;
                    break;
            }
        }

        public T GetService<T>()
        {
            return this.ServiceProvider.GetService<T>();
        }

        public IClientConfiguration GetClientConfiguration(string name)
        {
            return this.Configuration.GetSection(name).Get<ClientConfiguration>();
        }
    }
}
