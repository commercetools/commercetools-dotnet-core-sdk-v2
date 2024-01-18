using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchTimeRangeExpression))]
    public partial interface IProductSearchTimeRangeExpression : IProductSearchQueryExpression
    {
        IProductSearchTimeRangeValue Range { get; set; }

    }
}
