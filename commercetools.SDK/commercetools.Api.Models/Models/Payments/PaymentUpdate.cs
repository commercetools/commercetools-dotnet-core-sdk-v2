using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public class PaymentUpdate 
    {
        public long Version { get; set;}
        
        public List<PaymentUpdateAction> Actions { get; set;}
    }
}
