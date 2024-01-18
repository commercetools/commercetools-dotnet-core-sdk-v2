using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchNumberRangeValue))]
    public partial interface IProductSearchNumberRangeValue : IProductSearchQueryExpressionValue
    {
        decimal? Gte { get; set; }

        decimal? Gt { get; set; }

        decimal? Lte { get; set; }

        decimal? Lt { get; set; }

    }
}
