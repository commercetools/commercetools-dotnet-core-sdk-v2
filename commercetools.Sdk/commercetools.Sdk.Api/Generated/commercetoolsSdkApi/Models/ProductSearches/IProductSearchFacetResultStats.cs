using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetResultStats))]
    public partial interface IProductSearchFacetResultStats : IProductSearchFacetResult
    {
        Object Min { get; set; }

        Object Max { get; set; }

        Object Mean { get; set; }

        Object Sum { get; set; }

        long Count { get; set; }

    }
}
