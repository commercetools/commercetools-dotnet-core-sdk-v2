using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderPagedQueryResponse))]
    public partial interface IOrderPagedQueryResponse
    {
        long Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long Offset { get; set; }

        IList<IOrder> Results { get; set; }
        IEnumerable<IOrder> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
