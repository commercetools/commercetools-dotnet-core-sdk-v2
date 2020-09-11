using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyCartRemoveItemShippingAddressAction : MyCartUpdateAction
    {
        public string AddressKey { get; set;}
    }
}
