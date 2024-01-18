using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchDateTimeRangeExpression))]
    public partial interface IProductSearchDateTimeRangeExpression : IProductSearchQueryExpression
    {
        IProductSearchDateTimeRangeValue Range { get; set; }

    }
}
