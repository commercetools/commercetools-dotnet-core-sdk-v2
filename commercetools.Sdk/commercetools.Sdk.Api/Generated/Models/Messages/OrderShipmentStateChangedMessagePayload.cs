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

    public partial class OrderShipmentStateChangedMessagePayload : IOrderShipmentStateChangedMessagePayload
    {
        public string Type { get; set; }

        public IShipmentState ShipmentState { get; set; }

        public IShipmentState OldShipmentState { get; set; }
        public OrderShipmentStateChangedMessagePayload()
        {
            this.Type = "OrderShipmentStateChanged";
        }
    }
}
