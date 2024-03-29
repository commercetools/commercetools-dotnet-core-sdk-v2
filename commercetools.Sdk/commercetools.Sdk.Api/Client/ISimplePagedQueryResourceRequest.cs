#nullable enable
using System.Collections.Generic;

namespace commercetools.Sdk.Api.Client
{
    public interface ISimplePagedQueryResourceRequest<out T, TResult, out TQuery>
        where T : ISimplePagedQueryResourceRequest<T, TResult, TQuery>
        where TQuery : new()
    {
        T WithLimit(long limit);

        T WithOffset(long offset);

        T WithSort(string sort);

        T WithWhere(string where);

        T WithWithTotal(bool withTotal);

        T WithPredicateVar(string varName,
            string predicateVar);

        ICollection<KeyValuePair<string, string>> GetQueryParams();

        List<string> GetQueryParam(string key);

        string? GetFirstQueryParam(string key);

        TQuery QueryDsl() => new TQuery();
    }
}