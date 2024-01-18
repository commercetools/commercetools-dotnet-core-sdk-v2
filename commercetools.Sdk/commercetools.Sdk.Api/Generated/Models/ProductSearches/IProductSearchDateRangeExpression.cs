using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchDateRangeExpression))]
    public partial interface IProductSearchDateRangeExpression : IProductSearchQueryExpression
    {
        IProductSearchDateRangeValue Range { get; set; }

    }
}
