using commercetools.Base.Models;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchDateRangeValue))]
    public partial interface ISearchDateRangeValue : ISearchQueryExpressionValue
    {
        Date? Gte { get; set; }

        Date? Gt { get; set; }

        Date? Lte { get; set; }

        Date? Lt { get; set; }

    }
}
