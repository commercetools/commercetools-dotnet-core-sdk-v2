using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderPagedSearchResponse))]
    public partial interface IOrderPagedSearchResponse
    {
        long Total { get; set; }

        long? Offset { get; set; }

        long? Limit { get; set; }

        List<IHit> Hits { get; set; }
    }
}
