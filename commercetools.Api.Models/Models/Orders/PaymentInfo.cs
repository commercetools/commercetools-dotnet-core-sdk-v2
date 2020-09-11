using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class PaymentInfo 
    {
        public List<PaymentReference> Payments { get; set;}
    }
}
