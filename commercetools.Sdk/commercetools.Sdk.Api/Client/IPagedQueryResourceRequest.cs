#nullable enable

namespace commercetools.Sdk.Api.Client
{
    public interface IPagedQueryResourceRequest<out T, TResult, out TQuery> : ISimplePagedQueryResourceRequest<T, TResult, TQuery>
        where T : IPagedQueryResourceRequest<T, TResult, TQuery>
        where TQuery : new()
    {
        T WithExpand(string expand);
    }
}