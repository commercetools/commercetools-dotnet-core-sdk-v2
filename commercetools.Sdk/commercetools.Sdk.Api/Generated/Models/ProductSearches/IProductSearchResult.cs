using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchResult))]
    public partial interface IProductSearchResult
    {
        string Id { get; set; }

        IProductProjection ProductProjection { get; set; }

        IProductSearchMatchingVariants MatchingVariants { get; set; }

    }
}
