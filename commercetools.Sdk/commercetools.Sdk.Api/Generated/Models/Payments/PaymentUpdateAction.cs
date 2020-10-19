using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [Discriminator(nameof(Action))]
    public abstract partial class PaymentUpdateAction 
    {
        public string Action { get; set;}
    }
}
