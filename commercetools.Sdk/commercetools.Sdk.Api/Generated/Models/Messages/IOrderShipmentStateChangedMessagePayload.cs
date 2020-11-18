using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShipmentStateChangedMessagePayload))]
    public partial interface IOrderShipmentStateChangedMessagePayload : IMessagePayload
    {
        IShipmentState ShipmentState { get; set;}
        
        IShipmentState OldShipmentState { get; set;}
    }
}
