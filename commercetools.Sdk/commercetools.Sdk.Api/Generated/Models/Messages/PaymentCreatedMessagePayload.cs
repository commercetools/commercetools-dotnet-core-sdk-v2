using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class PaymentCreatedMessagePayload : IPaymentCreatedMessagePayload
    {
        public string Type { get; set;}
        
        public IPayment Payment { get; set;}
        public PaymentCreatedMessagePayload()
        { 
           this.Type = "PaymentCreated";
        }
    }
}
