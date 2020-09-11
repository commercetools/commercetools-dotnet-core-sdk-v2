using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderPaymentStateChangedMessagePayload : MessagePayload
    {
        public PaymentState PaymentState { get; set;}
        
        public PaymentState OldPaymentState { get; set;}
    }
}
