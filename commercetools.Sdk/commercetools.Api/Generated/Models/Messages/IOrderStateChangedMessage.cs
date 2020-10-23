using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Messages;
using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IOrderStateChangedMessage : IMessage
    {
        string OrderState { get; set;}
        
        OrderState OrderStateAsEnum { get; }
        
        string OldOrderState { get; set;}
        
        OrderState OldOrderStateAsEnum { get; }
    }
}
