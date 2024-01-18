using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchWildCardExpression))]
    public partial interface IProductSearchWildCardExpression : IProductSearchQueryExpression
    {
        IProductSearchAnyValue Wildcard { get; set; }

    }
}
