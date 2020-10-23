using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public  partial class PaymentSetMethodInfoNameAction : IPaymentSetMethodInfoNameAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Name { get; set;}
        public PaymentSetMethodInfoNameAction()
        { 
           this.Action = "setMethodInfoName";
        }
    }
}
