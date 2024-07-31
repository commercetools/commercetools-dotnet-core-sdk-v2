using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchTimeRangeExpression))]
    public partial interface ISearchTimeRangeExpression : ISearchQueryExpression
    {
        ISearchTimeRangeValue Range { get; set; }

    }
}
