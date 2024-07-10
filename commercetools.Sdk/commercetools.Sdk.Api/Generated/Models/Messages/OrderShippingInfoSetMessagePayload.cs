using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderShippingInfoSetMessagePayload : IOrderShippingInfoSetMessagePayload
    {
        public string Type { get; set; }

        public IShippingInfo ShippingInfo { get; set; }

        public IShippingInfo OldShippingInfo { get; set; }
        public OrderShippingInfoSetMessagePayload()
        {
            this.Type = "OrderShippingInfoSet";
        }
    }
}
