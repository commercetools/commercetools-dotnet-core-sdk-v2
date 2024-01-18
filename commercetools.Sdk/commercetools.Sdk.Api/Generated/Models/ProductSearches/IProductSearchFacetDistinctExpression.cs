using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFacetDistinctExpression))]
    public partial interface IProductSearchFacetDistinctExpression : IProductSearchFacetExpression
    {
        IProductSearchFacetDistinctValue Distinct { get; set; }

    }
}
