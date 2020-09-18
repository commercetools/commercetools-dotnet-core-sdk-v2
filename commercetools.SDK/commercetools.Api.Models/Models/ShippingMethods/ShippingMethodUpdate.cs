using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public class ShippingMethodUpdate 
    {
        public long Version { get; set;}
        
        public List<ShippingMethodUpdateAction> Actions { get; set;}
    }
}
