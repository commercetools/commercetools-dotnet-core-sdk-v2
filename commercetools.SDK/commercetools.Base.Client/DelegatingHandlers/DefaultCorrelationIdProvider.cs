using System;
namespace commercetools.Base.Client.DelegatingHandlers
{
    public class DefaultCorrelationIdProvider : ICorrelationIdProvider
    {
        public IClientConfiguration ClientConfiguration { get; set; }

        public string CorrelationId => $"{this.ClientConfiguration.ProjectKey}/{Guid.NewGuid()}";
    }
}
