using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingRatePriceTier : IShippingRatePriceTier
    {
        public IShippingRateTierType Type { get; set;}
    }
}
