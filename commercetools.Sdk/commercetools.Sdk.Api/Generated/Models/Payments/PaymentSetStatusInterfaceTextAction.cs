using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public  partial class PaymentSetStatusInterfaceTextAction : IPaymentSetStatusInterfaceTextAction
    {
        public string Action { get; set;}
        
        public string InterfaceText { get; set;}
        public PaymentSetStatusInterfaceTextAction()
        { 
           this.Action = "setStatusInterfaceText";
        }
    }
}
