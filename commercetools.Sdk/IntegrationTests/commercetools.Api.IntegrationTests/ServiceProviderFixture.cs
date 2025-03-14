﻿using System;
using System.Collections.Generic;
using commercetools.Sdk.Api.Models.Errors;
using commercetools.Base.Client;
using commercetools.Base.Client.Error;
using commercetools.Sdk.Api;
using commercetools.Sdk.Api.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace commercetools.Api.IntegrationTests
{
    public sealed class ServiceProviderFixture
    {
        private readonly ServiceProvider serviceProvider;
        private readonly IConfiguration configuration;

        public ServiceProviderFixture()
        {
            var services = new ServiceCollection();

            //services.AddLogging(configure => configure.AddConsole());
            this.configuration = new ConfigurationBuilder().
                AddInMemoryCollection(
                    new Dictionary<string, string>()
                    {
                        { "Logging:LogLevel:commercetoolsLoggerHandler", "Warning"},
                        { "Logging:LogLevel:System.Net.Http.HttpClient", "Warning"},
                    }).
                AddJsonFile("appsettings.test.Development.json", true).
                AddEnvironmentVariables().
                AddUserSecrets<ServiceProviderFixture>().
                AddEnvironmentVariables("CTP_").
                Build();

            var useStreamClient = Enum.Parse<ClientType>(configuration.GetValue("ClientType", "String")) != ClientType.String;
            services.UseCommercetoolsApi(configuration, "Client", options: new ClientOptions { ReadResponseAsStream = useStreamClient });
            services.AddLogging(c => c.AddConfiguration(configuration.GetSection("Logging")));
            services.AddLogging(c => c.AddProvider(new InMemoryLoggerProvider()));
            services.AddLogging(c => c.AddSimpleConsole(o =>
            {
                o.UseUtcTimestamp = true;
                o.IncludeScopes = true;
                o.TimestampFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFK ";
                o.SingleLine = true;
            }));
            services.SetupClient(
                "MeClient",
                errorTypeMapper => typeof(ErrorResponse),
                s => s.GetService<IApiSerializerService>()
            );
            services.AddSingleton<ILoggerHandlerOptions>(new LoggerHandlerOptions()
            {
                ResponseLogEvent = LogLevel.Information,
                DefaultExceptionLogEvent = LogLevel.Warning,
                ExceptionLogEvents = new Dictionary<System.Type, LogLevel>()
                {
                    { typeof(NotFoundException), LogLevel.Information },
                    { typeof(ConcurrentModificationException), LogLevel.Information}
                }
            });
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
