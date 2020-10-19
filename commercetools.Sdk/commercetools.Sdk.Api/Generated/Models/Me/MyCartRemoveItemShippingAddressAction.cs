using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("removeItemShippingAddress")]
    public partial class MyCartRemoveItemShippingAddressAction : MyCartUpdateAction
    {
        public string AddressKey { get; set;}
        public MyCartRemoveItemShippingAddressAction()
        { 
           this.Action = "removeItemShippingAddress";
        }
    }
}
