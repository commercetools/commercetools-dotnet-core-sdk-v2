using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("DeliveryRemoved")]
    public partial class DeliveryRemovedMessage : Message
    {
        public Delivery Delivery { get; set;}
        public DeliveryRemovedMessage()
        { 
           this.Type = "DeliveryRemoved";
        }
    }
}
