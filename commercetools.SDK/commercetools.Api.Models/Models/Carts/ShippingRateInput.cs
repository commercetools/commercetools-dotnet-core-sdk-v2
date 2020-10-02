using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [Discriminator(nameof(Type))]
    public abstract partial class ShippingRateInput 
    {
        public string Type { get; set;}
    }
}
