using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderPaymentStateChangedMessage : Message
    {
        public PaymentState PaymentState { get; set;}
        
        public PaymentState OldPaymentState { get; set;}
    }
}
