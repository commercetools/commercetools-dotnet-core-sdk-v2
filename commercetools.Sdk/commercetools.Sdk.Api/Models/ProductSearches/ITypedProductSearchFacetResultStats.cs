using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    public partial interface ITypedProductSearchFacetResultStats<T> : IProductSearchFacetResult
    {
        Type Type => typeof(T);

        T Min { get; set; }

        T Max { get; set; }

        T Mean { get; set; }

        T Sum { get; set; }

        long Count { get; set; }

    }
}
