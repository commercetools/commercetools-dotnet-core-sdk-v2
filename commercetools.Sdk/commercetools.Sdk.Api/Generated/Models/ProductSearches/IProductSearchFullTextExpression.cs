using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchFullTextExpression))]
    public partial interface IProductSearchFullTextExpression : IProductSearchQueryExpression
    {
        IProductSearchFullTextValue FullText { get; set; }

    }
}
