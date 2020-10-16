using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("DeliveryAdded")]
    public partial class DeliveryAddedMessage : Message
    {
        public Delivery Delivery { get; set;}
        public DeliveryAddedMessage()
        { 
           this.Type = "DeliveryAdded";
        }
    }
}
