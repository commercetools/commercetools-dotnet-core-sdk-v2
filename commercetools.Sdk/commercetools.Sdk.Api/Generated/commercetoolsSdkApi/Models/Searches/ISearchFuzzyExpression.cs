using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchFuzzyExpression))]
    public partial interface ISearchFuzzyExpression : ISearchQueryExpression
    {
        ISearchFuzzyValue Fuzzy { get; set; }

    }
}
