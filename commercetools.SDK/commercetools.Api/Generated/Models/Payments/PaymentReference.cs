using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("payment")]
    public partial class PaymentReference : Reference
    {
        public Payment Obj { get; set;}
        public PaymentReference()
        { 
           this.TypeId = "payment";
        }
    }
}
