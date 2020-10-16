using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("shipping-method")]
    public partial class ShippingMethodReference : Reference
    {
        public ShippingMethod Obj { get; set;}
        public ShippingMethodReference()
        { 
           this.TypeId = "shipping-method";
        }
    }
}
