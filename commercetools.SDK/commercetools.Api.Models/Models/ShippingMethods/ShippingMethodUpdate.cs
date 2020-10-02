using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodUpdate 
    {
        public long Version { get; set;}
        
        public List<ShippingMethodUpdateAction> Actions { get; set;}
    }
}
