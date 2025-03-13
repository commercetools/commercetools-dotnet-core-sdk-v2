namespace commercetools.Sdk.Api.Models;

public interface IResourcePageableQueryResponse<T> : IResourceQueryResponse<T>
{
    public long? Limit { get; set; }

    public long? Offset { get; set; }

    public long? Total { get; set; }
}