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

    public partial class OrderLineItemAddedMessagePayload : IOrderLineItemAddedMessagePayload
    {
        public string Type { get; set; }

        public ILineItem LineItem { get; set; }

        public long AddedQuantity { get; set; }
        public OrderLineItemAddedMessagePayload()
        {
            this.Type = "OrderLineItemAdded";
        }
    }
}
