using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setAnonymousId")]
    public partial class PaymentSetAnonymousIdAction : PaymentUpdateAction
    {
        public string AnonymousId { get; set;}
        public PaymentSetAnonymousIdAction()
        { 
           this.Action = "setAnonymousId";
        }
    }
}
