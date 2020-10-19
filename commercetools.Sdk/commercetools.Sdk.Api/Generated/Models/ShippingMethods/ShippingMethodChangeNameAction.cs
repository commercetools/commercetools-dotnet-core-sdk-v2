using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DiscriminatorValue("changeName")]
    public partial class ShippingMethodChangeNameAction : ShippingMethodUpdateAction
    {
        public string Name { get; set;}
        public ShippingMethodChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
