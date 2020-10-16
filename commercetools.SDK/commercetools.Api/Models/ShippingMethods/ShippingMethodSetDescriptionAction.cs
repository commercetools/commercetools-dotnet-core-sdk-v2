using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("setDescription")]
    public partial class ShippingMethodSetDescriptionAction : ShippingMethodUpdateAction
    {
        public string Description { get; set;}
        public ShippingMethodSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
