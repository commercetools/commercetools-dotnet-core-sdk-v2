using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("addItemShippingAddress")]
    public partial class CartAddItemShippingAddressAction : CartUpdateAction
    {
        public Address Address { get; set;}
        public CartAddItemShippingAddressAction()
        { 
           this.Action = "addItemShippingAddress";
        }
    }
}
