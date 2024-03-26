using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchWildCardExpression))]
    public partial interface ISearchWildCardExpression : ISearchQueryExpression
    {
        ISearchAnyValue Wildcard { get; set; }

    }
}
