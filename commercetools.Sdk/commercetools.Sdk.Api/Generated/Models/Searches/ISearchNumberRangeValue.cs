using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchNumberRangeValue))]
    public partial interface ISearchNumberRangeValue : ISearchQueryExpressionValue
    {
        decimal? Gte { get; set; }

        decimal? Gt { get; set; }

        decimal? Lte { get; set; }

        decimal? Lt { get; set; }

    }
}
