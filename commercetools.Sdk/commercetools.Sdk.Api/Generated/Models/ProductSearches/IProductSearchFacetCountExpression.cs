using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetCountExpression))]
    public partial interface IProductSearchFacetCountExpression : IProductSearchFacetExpression
    {
        IProductSearchFacetCountValue Count { get; set; }

    }
}
