using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchExactExpression))]
    public partial interface IProductSearchExactExpression : IProductSearchQueryExpression
    {
        IProductSearchAnyValue Exact { get; set; }

    }
}
