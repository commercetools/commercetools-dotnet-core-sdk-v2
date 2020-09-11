using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyCartAddItemShippingAddressAction : MyCartUpdateAction
    {
        public Address Address { get; set;}
    }
}
