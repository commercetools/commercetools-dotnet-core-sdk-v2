using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setShippingAddress")]
    public partial class CartSetShippingAddressAction : CartUpdateAction
    {
        public Address Address { get; set;}
        public CartSetShippingAddressAction()
        { 
           this.Action = "setShippingAddress";
        }
    }
}
