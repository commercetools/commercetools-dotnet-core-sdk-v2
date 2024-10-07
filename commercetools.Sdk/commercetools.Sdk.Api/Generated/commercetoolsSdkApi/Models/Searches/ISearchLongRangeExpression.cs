using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchLongRangeExpression))]
    public partial interface ISearchLongRangeExpression : ISearchQueryExpression
    {
        ISearchLongRangeValue Range { get; set; }

    }
}
