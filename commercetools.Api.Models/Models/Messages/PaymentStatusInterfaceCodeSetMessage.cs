using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class PaymentStatusInterfaceCodeSetMessage : Message
    {
        public string PaymentId { get; set;}
        
        public string InterfaceCode { get; set;}
    }
}
