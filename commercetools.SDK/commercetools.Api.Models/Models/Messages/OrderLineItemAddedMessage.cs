using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderLineItemAdded")]
    public class OrderLineItemAddedMessage : Message
    {
        public LineItem LineItem { get; set;}
        
        public long AddedQuantity { get; set;}
    }
}
