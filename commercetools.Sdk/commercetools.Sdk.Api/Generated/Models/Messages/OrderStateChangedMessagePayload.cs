using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderStateChangedMessagePayload : IOrderStateChangedMessagePayload
    {
        public string Type { get; set; }

        public IOrderState OrderState { get; set; }

        public IOrderState OldOrderState { get; set; }
        public OrderStateChangedMessagePayload()
        {
            this.Type = "OrderStateChanged";
        }
    }
}
