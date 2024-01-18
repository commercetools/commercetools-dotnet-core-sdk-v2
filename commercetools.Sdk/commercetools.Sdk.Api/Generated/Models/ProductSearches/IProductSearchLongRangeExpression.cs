using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchLongRangeExpression))]
    public partial interface IProductSearchLongRangeExpression : IProductSearchQueryExpression
    {
        IProductSearchLongRangeValue Range { get; set; }

    }
}
