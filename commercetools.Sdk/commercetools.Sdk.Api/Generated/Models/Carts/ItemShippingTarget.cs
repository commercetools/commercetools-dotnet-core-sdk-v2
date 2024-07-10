using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ItemShippingTarget : IItemShippingTarget
    {
        public string AddressKey { get; set; }

        public long Quantity { get; set; }

        public string ShippingMethodKey { get; set; }
    }
}
