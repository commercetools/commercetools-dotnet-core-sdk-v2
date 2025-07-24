using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.RecurringOrders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.RecurringOrders.RecurringOrderPagedQueryResponse))]
    public partial interface IRecurringOrderPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IRecurringOrder> Results { get; set; }

        IEnumerable<IRecurringOrder> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
