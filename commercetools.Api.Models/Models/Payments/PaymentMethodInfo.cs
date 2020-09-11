using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Payments
{
    public class PaymentMethodInfo 
    {
        public string PaymentInterface { get; set;}
        
        public string Method { get; set;}
        
        public LocalizedString Name { get; set;}
    }
}
