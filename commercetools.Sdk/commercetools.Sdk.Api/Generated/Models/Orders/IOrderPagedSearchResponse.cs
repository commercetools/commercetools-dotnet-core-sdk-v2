using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderPagedSearchResponse))]
    public partial interface IOrderPagedSearchResponse
    {
        long Total { get; set; }

        long? Offset { get; set; }

        long? Limit { get; set; }

        IList<IHit> Hits { get; set; }
        IEnumerable<IHit> HitsEnumerable { set => Hits = value.ToList(); }


    }
}
