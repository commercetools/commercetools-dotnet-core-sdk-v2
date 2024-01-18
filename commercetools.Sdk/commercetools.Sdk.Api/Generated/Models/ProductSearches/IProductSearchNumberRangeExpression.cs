using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchNumberRangeExpression))]
    public partial interface IProductSearchNumberRangeExpression : IProductSearchQueryExpression
    {
        IProductSearchNumberRangeValue Range { get; set; }

    }
}
