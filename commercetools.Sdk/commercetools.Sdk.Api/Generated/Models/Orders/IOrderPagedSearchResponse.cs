using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderPagedSearchResponse))]
    public partial interface IOrderPagedSearchResponse
    {
        long Total { get; set; }

        long? Offset { get; set; }

        long? Limit { get; set; }

        List<IHit> Hits { get; set; }

    }
}
