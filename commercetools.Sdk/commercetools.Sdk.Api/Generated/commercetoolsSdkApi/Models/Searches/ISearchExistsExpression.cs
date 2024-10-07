using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchExistsExpression))]
    public partial interface ISearchExistsExpression : ISearchQueryExpression
    {
        ISearchExistsValue Exists { get; set; }

    }
}
