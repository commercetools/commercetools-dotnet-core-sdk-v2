namespace commercetools.Sdk.Api.Models;

public interface IResourcePagedQueryResponse<T> : IResourceQueryResponse<T>
{
    public long Limit { get; set; }

    public long Offset { get; set; }

    public long? Total { get; set; }
}