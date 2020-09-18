using commercetools.Api.Models.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [Discriminator(nameof(Action))]
    public abstract class PaymentUpdateAction 
    {
        public string Action { get; set;}
    }
}
