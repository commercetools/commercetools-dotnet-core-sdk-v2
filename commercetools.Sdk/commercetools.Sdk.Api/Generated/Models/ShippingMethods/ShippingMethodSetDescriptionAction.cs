using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    public partial class ShippingMethodSetDescriptionAction : IShippingMethodSetDescriptionAction
    {
        public string Action { get; set;}
        
        public string Description { get; set;}
        public ShippingMethodSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
