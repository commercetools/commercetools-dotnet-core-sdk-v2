using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetAnonymousIdAction : IPaymentSetAnonymousIdAction
    {
        public string Action { get; set;}
        
        public string AnonymousId { get; set;}
        public PaymentSetAnonymousIdAction()
        { 
           this.Action = "setAnonymousId";
        }
    }
}
