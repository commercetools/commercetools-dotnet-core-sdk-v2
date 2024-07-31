using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchDateTimeRangeExpression))]
    public partial interface ISearchDateTimeRangeExpression : ISearchQueryExpression
    {
        ISearchDateTimeRangeValue Range { get; set; }

    }
}
