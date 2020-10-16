namespace commercetools.Base.Client.DelegatingHandlers
{
    public interface ICorrelationIdProvider
    {
        string CorrelationId { get; }

        IClientConfiguration ClientConfiguration { get; set; }
    }
}
