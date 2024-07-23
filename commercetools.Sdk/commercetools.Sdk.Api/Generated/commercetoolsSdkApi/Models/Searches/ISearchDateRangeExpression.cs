using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchDateRangeExpression))]
    public partial interface ISearchDateRangeExpression : ISearchQueryExpression
    {
        ISearchDateRangeValue Range { get; set; }

    }
}
