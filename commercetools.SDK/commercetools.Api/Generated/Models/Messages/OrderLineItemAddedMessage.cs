using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderLineItemAdded")]
    public partial class OrderLineItemAddedMessage : Message
    {
        public LineItem LineItem { get; set;}
        
        public long AddedQuantity { get; set;}
        public OrderLineItemAddedMessage()
        { 
           this.Type = "OrderLineItemAdded";
        }
    }
}
