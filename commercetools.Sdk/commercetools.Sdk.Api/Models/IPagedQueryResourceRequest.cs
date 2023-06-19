using System.Collections.Generic;

namespace commercetools.Sdk.Api.Models
{
    public interface IPagedQueryResourceRequest<out T, TResult> : IRequestCommand<TResult>
        where T : IPagedQueryResourceRequest<T, TResult>
    {
        T WithLimit(int limit);

        T WithOffset(int offset);

        T WithSort(string sort);

        T WithWhere(string where);

        T WithExpand(string expand);

        T WithWithTotal(bool withTotal);

        T WithPredicateVar(string varName, string predicateVar);

        List<string> GetQueryParam(string key);
    }
}