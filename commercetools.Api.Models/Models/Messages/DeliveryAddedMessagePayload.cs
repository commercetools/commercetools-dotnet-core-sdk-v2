using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class DeliveryAddedMessagePayload : MessagePayload
    {
        public Delivery Delivery { get; set;}
    }
}
