using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchLongRangeValue))]
    public partial interface ISearchLongRangeValue : ISearchQueryExpressionValue
    {
        long? Gte { get; set; }

        long? Gt { get; set; }

        long? Lte { get; set; }

        long? Lt { get; set; }

    }
}
