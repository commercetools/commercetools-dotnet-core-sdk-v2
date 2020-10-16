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
    public partial class DeliveryRemovedMessagePayload : MessagePayload
    {
        public Delivery Delivery { get; set;}
        public DeliveryRemovedMessagePayload()
        { 
           this.Type = "DeliveryRemoved";
        }
    }
}
