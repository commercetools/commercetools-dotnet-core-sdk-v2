using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("setCustomField")]
    public class PaymentSetCustomFieldAction : PaymentUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
