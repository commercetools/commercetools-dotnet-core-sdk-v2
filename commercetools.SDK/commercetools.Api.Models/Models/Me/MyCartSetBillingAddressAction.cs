using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setBillingAddress")]
    public class MyCartSetBillingAddressAction : MyCartUpdateAction
    {
        public Address Address { get; set;}
    }
}
