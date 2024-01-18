using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchDateRangeValue))]
    public partial interface IProductSearchDateRangeValue : IProductSearchQueryExpressionValue
    {
        Date? Gte { get; set; }

        Date? Gt { get; set; }

        Date? Lte { get; set; }

        Date? Lt { get; set; }

    }
}
