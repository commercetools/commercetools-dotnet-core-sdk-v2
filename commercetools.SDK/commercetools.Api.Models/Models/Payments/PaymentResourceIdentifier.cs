using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DiscriminatorValue("payment")]
    public partial class PaymentResourceIdentifier : ResourceIdentifier
    {
        public PaymentResourceIdentifier()
        { 
           this.TypeId = "payment";
        }
    }
}
