using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchQueryExpressionValue))]
    public partial interface ISearchQueryExpressionValue
    {
        string Field { get; set; }

        decimal? Boost { get; set; }

        ISearchFieldType FieldType { get; set; }

    }
}
