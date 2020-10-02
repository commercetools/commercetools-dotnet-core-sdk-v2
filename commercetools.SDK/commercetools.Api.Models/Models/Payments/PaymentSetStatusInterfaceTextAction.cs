using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setStatusInterfaceText")]
    public partial class PaymentSetStatusInterfaceTextAction : PaymentUpdateAction
    {
        public string InterfaceText { get; set;}
        public PaymentSetStatusInterfaceTextAction()
        { 
           this.Action = "setStatusInterfaceText";
        }
    }
}
