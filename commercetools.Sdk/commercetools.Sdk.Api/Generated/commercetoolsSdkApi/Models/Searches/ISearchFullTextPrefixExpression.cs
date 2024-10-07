using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchFullTextPrefixExpression))]
    public partial interface ISearchFullTextPrefixExpression : ISearchQueryExpression
    {
        ISearchFullTextPrefixValue FullTextPrefix { get; set; }

    }
}
