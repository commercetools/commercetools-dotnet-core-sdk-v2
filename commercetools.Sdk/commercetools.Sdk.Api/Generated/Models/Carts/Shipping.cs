using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class Shipping : IShipping
    {
        public string ShippingKey { get; set; }

        public IShippingInfo ShippingInfo { get; set; }

        public IAddress ShippingAddress { get; set; }

        public IShippingRateInput ShippingRateInput { get; set; }

        public ICustomFields ShippingCustomFields { get; set; }
    }
}
