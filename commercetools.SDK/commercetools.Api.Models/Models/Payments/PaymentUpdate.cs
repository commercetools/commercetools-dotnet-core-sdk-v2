using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentUpdate 
    {
        public long Version { get; set;}
        
        public List<PaymentUpdateAction> Actions { get; set;}
    }
}
