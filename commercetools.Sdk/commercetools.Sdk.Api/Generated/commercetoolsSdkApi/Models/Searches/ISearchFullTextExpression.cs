using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchFullTextExpression))]
    public partial interface ISearchFullTextExpression : ISearchQueryExpression
    {
        ISearchFullTextValue FullText { get; set; }

    }
}
