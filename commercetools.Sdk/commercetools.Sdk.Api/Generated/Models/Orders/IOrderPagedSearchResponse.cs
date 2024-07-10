using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
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
