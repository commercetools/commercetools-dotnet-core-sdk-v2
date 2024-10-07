using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetRangesFacetRange))]
    public partial interface IProductSearchFacetRangesFacetRange
    {
        Object From { get; set; }

        Object To { get; set; }

        string Key { get; set; }

    }
}
