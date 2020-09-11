using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderReturnShipmentStateChangedMessage : Message
    {
        public string ReturnItemId { get; set;}
        
        public ReturnShipmentState ReturnShipmentState { get; set;}
    }
}
