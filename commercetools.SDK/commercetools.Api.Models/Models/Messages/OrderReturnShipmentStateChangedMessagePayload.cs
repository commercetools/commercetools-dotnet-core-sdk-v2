using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderReturnShipmentStateChanged")]
    public class OrderReturnShipmentStateChangedMessagePayload : MessagePayload
    {
        public string ReturnItemId { get; set;}
        
        public string ReturnShipmentState { get; set;}
        
        public ReturnShipmentState ReturnShipmentStateAsEnum => this.ReturnShipmentState.GetEnum<ReturnShipmentState>();
    }
}
