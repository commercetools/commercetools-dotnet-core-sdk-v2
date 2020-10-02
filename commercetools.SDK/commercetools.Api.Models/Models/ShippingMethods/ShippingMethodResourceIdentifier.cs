using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("shipping-method")]
    public partial class ShippingMethodResourceIdentifier : ResourceIdentifier
    {
        public ShippingMethodResourceIdentifier()
        { 
           this.TypeId = "shipping-method";
        }
    }
}
