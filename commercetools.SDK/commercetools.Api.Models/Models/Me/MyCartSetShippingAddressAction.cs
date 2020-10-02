using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setShippingAddress")]
    public partial class MyCartSetShippingAddressAction : MyCartUpdateAction
    {
        public Address Address { get; set;}
        public MyCartSetShippingAddressAction()
        { 
           this.Action = "setShippingAddress";
        }
    }
}
