using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodPagedQueryResponse))]
    public partial interface IShippingMethodPagedQueryResponse
    {
        long? Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long? Offset { get; set; }

        List<IShippingMethod> Results { get; set; }
    }
}
