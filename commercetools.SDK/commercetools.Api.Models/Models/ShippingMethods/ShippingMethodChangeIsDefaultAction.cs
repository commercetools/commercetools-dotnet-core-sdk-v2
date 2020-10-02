using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("changeIsDefault")]
    public partial class ShippingMethodChangeIsDefaultAction : ShippingMethodUpdateAction
    {
        public bool IsDefault { get; set;}
        public ShippingMethodChangeIsDefaultAction()
        { 
           this.Action = "changeIsDefault";
        }
    }
}
