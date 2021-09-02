using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderShippingRateInputSetMessagePayload : IOrderShippingRateInputSetMessagePayload
    {
        public string Type { get; set; }

        public IShippingRateInput ShippingRateInput { get; set; }

        public IShippingRateInput OldShippingRateInput { get; set; }
        public OrderShippingRateInputSetMessagePayload()
        {
            this.Type = "OrderShippingRateInputSet";
        }
    }
}
