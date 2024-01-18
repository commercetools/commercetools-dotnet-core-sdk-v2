using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchPrefixExpression))]
    public partial interface IProductSearchPrefixExpression : IProductSearchQueryExpression
    {
        IProductSearchAnyValue Prefix { get; set; }

    }
}
