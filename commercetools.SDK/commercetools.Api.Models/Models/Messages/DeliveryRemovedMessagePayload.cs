using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("DeliveryRemoved")]
    public class DeliveryRemovedMessagePayload : MessagePayload
    {
        public Delivery Delivery { get; set;}
    }
}
