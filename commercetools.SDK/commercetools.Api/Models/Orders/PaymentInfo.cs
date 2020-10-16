using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Orders
{
    public partial class PaymentInfo 
    {
        public List<PaymentReference> Payments { get; set;}
    }
}
