using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setKey")]
    public partial class PaymentSetKeyAction : PaymentUpdateAction
    {
        public string Key { get; set;}
        public PaymentSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
