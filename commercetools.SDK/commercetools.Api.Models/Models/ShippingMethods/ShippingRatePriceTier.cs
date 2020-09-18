using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [Discriminator(nameof(Type))]
    public abstract class ShippingRatePriceTier 
    {
        public string Type { get; set;}
        
        public ShippingRateTierType TypeAsEnum => this.Type.GetEnum<ShippingRateTierType>();
    }
}
