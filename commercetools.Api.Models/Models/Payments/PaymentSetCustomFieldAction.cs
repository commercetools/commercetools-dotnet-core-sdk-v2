using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class PaymentSetCustomFieldAction : PaymentUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
