using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentSetKeyAction : IPaymentSetKeyAction
    {
        public string Action { get; set;}
        
        public string Key { get; set;}
        public PaymentSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
