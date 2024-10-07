using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchExistsValue))]
    public partial interface ISearchExistsValue : ISearchQueryExpressionValue
    {
        string Language { get; set; }

    }
}
