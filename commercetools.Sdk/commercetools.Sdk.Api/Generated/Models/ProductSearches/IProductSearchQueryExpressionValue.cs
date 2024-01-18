using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchQueryExpressionValue))]
    public partial interface IProductSearchQueryExpressionValue
    {
        string Field { get; set; }

        decimal? Boost { get; set; }

        IProductSearchAttributeType AttributeType { get; set; }

    }
}
