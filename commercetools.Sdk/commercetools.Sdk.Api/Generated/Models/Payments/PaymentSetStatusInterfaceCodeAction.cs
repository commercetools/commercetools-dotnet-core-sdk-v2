using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetStatusInterfaceCodeAction : IPaymentSetStatusInterfaceCodeAction
    {
        public string Action { get; set;}
        
        public string InterfaceCode { get; set;}
        public PaymentSetStatusInterfaceCodeAction()
        { 
           this.Action = "setStatusInterfaceCode";
        }
    }
}
