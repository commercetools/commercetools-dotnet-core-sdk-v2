using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("PaymentStatusInterfaceCodeSet")]
    public partial class PaymentStatusInterfaceCodeSetMessage : Message
    {
        public string PaymentId { get; set;}
        
        public string InterfaceCode { get; set;}
        public PaymentStatusInterfaceCodeSetMessage()
        { 
           this.Type = "PaymentStatusInterfaceCodeSet";
        }
    }
}
