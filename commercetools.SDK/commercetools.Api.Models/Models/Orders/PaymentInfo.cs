using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public class PaymentInfo 
    {
        public List<PaymentReference> Payments { get; set;}
    }
}
