using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.DiscountGroups
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountGroups.DiscountGroupPagedQueryResponse))]
    public partial interface IDiscountGroupPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IDiscountGroup> Results { get; set; }

        IEnumerable<IDiscountGroup> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
