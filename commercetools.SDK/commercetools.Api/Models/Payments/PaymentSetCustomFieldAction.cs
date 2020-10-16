using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setCustomField")]
    public partial class PaymentSetCustomFieldAction : PaymentUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public PaymentSetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
