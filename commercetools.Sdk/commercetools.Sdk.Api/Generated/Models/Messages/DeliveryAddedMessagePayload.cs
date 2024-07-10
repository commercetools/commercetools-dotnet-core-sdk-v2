using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class DeliveryAddedMessagePayload : IDeliveryAddedMessagePayload
    {
        public string Type { get; set; }

        public IDelivery Delivery { get; set; }

        public string ShippingKey { get; set; }
        public DeliveryAddedMessagePayload()
        {
            this.Type = "DeliveryAdded";
        }
    }
}
