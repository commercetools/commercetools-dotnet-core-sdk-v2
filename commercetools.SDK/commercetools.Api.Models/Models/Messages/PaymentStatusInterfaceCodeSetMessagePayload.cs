using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentStatusInterfaceCodeSet")]
    public class PaymentStatusInterfaceCodeSetMessagePayload : MessagePayload
    {
        public string PaymentId { get; set;}
        
        public string InterfaceCode { get; set;}
    }
}
