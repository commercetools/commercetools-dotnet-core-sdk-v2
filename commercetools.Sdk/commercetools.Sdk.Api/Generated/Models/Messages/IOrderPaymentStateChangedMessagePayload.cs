using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderPaymentStateChangedMessagePayload))]
    public interface IOrderPaymentStateChangedMessagePayload : IMessagePayload
    {
        string PaymentState { get; set;}
        
        PaymentState PaymentStateAsEnum { get; }
        
        string OldPaymentState { get; set;}
        
        PaymentState OldPaymentStateAsEnum { get; }
    }
}
