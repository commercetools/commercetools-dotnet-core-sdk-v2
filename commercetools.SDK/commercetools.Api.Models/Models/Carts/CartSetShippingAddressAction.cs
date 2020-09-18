using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setShippingAddress")]
    public class CartSetShippingAddressAction : CartUpdateAction
    {
        public Address Address { get; set;}
    }
}
