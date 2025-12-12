using commercetools.Sdk.Api.Models.Products;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchResult))]
    public partial interface IProductSearchResult
    {
        string Id { get; set; }

        IProductSearchMatchingVariants MatchingVariants { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IProductProjection ProductProjection { get; set; }

    }
}
