using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodUpdate : IShippingMethodUpdate
    {
        public long Version { get; set;}
        
        public List<IShippingMethodUpdateAction> Actions { get; set;}
    }
}
