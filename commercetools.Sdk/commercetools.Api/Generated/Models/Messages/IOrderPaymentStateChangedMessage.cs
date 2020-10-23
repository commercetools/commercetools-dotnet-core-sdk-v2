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
    public interface IOrderPaymentStateChangedMessage : IMessage
    {
        string PaymentState { get; set;}
        
        PaymentState PaymentStateAsEnum { get; }
        
        string OldPaymentState { get; set;}
        
        PaymentState OldPaymentStateAsEnum { get; }
    }
}
