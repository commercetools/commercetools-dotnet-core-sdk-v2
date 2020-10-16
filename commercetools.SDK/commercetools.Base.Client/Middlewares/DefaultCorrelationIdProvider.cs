using System;
namespace commercetools.Base.Client.Middlewares
{
    public class DefaultCorrelationIdProvider : ICorrelationIdProvider
    {
        public DefaultCorrelationIdProvider(IClientConfiguration clientConfiguration)
        {
            ClientConfiguration = clientConfiguration;
        }

        public IClientConfiguration ClientConfiguration { get; set; }

        public string CorrelationId => $"{this.ClientConfiguration.ProjectKey}/{Guid.NewGuid()}";
    }
}
