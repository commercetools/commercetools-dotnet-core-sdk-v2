using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchLongRangeValue))]
    public partial interface IProductSearchLongRangeValue : IProductSearchQueryExpressionValue
    {
        long? Gte { get; set; }

        long? Gt { get; set; }

        long? Lte { get; set; }

        long? Lt { get; set; }

    }
}
