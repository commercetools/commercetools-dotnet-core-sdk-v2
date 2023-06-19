#nullable enable
using System.Collections.Generic;

namespace commercetools.Sdk.Api.Client
{
    public interface IPagedQueryResourceRequest<out T, TResult, out TQuery>
        where T : IPagedQueryResourceRequest<T, TResult, TQuery>
        where TQuery : new()
    {
        T WithLimit(int limit);
        
        T WithOffset(int offset);

        T WithSort(string sort);

        T WithWhere(string where);

        T WithExpand(string expand);

        T WithWithTotal(bool withTotal);

        T WithPredicateVar(string varName,
            string predicateVar);
        
        ICollection<KeyValuePair<string, string>> GetQueryParams();

        List<string> GetQueryParam(string key);

        string? GetFirstQueryParam(string key);

        TQuery QueryDsl() => new TQuery();
    }
}