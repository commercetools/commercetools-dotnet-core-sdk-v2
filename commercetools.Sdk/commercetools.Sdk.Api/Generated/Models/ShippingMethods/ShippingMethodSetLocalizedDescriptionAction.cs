using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("setLocalizedDescription")]
    public partial class ShippingMethodSetLocalizedDescriptionAction : ShippingMethodUpdateAction
    {
        public string LocalizedDescription { get; set;}
        public ShippingMethodSetLocalizedDescriptionAction()
        { 
           this.Action = "setLocalizedDescription";
        }
    }
}
