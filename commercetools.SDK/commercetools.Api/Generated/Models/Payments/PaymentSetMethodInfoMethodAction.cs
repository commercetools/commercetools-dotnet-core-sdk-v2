using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setMethodInfoMethod")]
    public partial class PaymentSetMethodInfoMethodAction : PaymentUpdateAction
    {
        public string Method { get; set;}
        public PaymentSetMethodInfoMethodAction()
        { 
           this.Action = "setMethodInfoMethod";
        }
    }
}
