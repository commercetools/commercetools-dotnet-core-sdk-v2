using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentStatusInterfaceCodeSet")]
    public partial class PaymentStatusInterfaceCodeSetMessagePayload : MessagePayload
    {
        public string PaymentId { get; set;}
        
        public string InterfaceCode { get; set;}
        public PaymentStatusInterfaceCodeSetMessagePayload()
        { 
           this.Type = "PaymentStatusInterfaceCodeSet";
        }
    }
}
