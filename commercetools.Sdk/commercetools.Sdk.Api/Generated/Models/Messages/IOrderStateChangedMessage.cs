using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderStateChangedMessage))]
    public partial interface IOrderStateChangedMessage : IMessage
    {
        string OrderState { get; set;}
        
        OrderState OrderStateAsEnum { get; }
        
        string OldOrderState { get; set;}
        
        OrderState OldOrderStateAsEnum { get; }
    }
}
