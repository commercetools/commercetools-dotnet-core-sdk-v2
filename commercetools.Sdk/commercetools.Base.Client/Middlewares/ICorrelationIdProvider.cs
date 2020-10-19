namespace commercetools.Base.Client.Middlewares
{
    public interface ICorrelationIdProvider
    {
        string CorrelationId { get; }

        IClientConfiguration ClientConfiguration { get; set; }
    }
}
