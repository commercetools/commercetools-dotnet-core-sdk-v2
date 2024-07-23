using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchPrefixExpression))]
    public partial interface ISearchPrefixExpression : ISearchQueryExpression
    {
        ISearchAnyValue Prefix { get; set; }

    }
}
