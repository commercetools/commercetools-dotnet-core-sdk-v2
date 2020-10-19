using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [Discriminator(nameof(Type))]
    public abstract partial class ShippingRateInputDraft 
    {
        public string Type { get; set;}
    }
}
