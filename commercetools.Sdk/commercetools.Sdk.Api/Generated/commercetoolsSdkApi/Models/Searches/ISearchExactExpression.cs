using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchExactExpression))]
    public partial interface ISearchExactExpression : ISearchQueryExpression
    {
        ISearchAnyValue Exact { get; set; }

    }
}
