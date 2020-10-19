using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("removeItemShippingAddress")]
    public partial class CartRemoveItemShippingAddressAction : CartUpdateAction
    {
        public string AddressKey { get; set;}
        public CartRemoveItemShippingAddressAction()
        { 
           this.Action = "removeItemShippingAddress";
        }
    }
}
