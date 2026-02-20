using System.Collections.Generic;
using System.Linq;
using commercetools.Sdk.Api.Models.ProductSearches;

namespace commercetools.Sdk.Api.Extensions;

public static class FacetExtensions
{
    public static IProductSearchFacetResult Get(this IList<IProductSearchFacetResult> facets, string name)
    {
        var facetResult = facets.FirstOrDefault(result => result.Name.Equals(name));

        return facetResult;
    }

    public static bool TryGet(this IList<IProductSearchFacetResult> facets, string name, out IProductSearchFacetResult facetResult)
    {
        facetResult = facets.FirstOrDefault(result => result.Name.Equals(name));
        return facetResult != null;
    }

    public static ITypedProductSearchFacetResultStats<T> Get<T>(this IProductSearchFacetResultStats stats)
    {
        return new TypedProductSearchFacetResultStats<T>()
        {
            Name = stats.Name,
            Min = (T)stats.Min,
            Max = (T)stats.Max,
            Mean = (T)stats.Mean,
            Sum = (T)stats.Sum,
            Count = stats.Count
        };
    }
}