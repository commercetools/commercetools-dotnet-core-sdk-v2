using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchExistsValue))]
    public partial interface IProductSearchExistsValue : IProductSearchQueryExpressionValue
    {
        string Language { get; set; }

    }
}
