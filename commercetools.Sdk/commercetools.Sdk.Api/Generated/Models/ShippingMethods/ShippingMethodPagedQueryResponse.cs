using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodPagedQueryResponse : IShippingMethodPagedQueryResponse
    {
        public long? Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long? Offset { get; set; }

        public List<IShippingMethod> Results { get; set; }
    }
}
