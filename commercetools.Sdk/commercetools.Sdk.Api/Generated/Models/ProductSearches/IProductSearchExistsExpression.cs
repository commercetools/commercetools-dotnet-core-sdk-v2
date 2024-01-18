using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchExistsExpression))]
    public partial interface IProductSearchExistsExpression : IProductSearchQueryExpression
    {
        IProductSearchExistsValue Exists { get; set; }

    }
}
