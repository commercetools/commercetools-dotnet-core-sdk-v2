using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSearchRequest))]
    public partial interface IOrderSearchRequest
    {
        IOrderSearchQuery Query { get; set; }

        IList<IOrderSearchSorting> Sort { get; set; }
        IEnumerable<IOrderSearchSorting> SortEnumerable { set => Sort = value.ToList(); }


        int? Limit { get; set; }

        int? Offset { get; set; }

    }
}
