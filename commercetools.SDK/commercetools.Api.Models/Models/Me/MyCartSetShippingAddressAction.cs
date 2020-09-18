using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setShippingAddress")]
    public class MyCartSetShippingAddressAction : MyCartUpdateAction
    {
        public Address Address { get; set;}
    }
}
