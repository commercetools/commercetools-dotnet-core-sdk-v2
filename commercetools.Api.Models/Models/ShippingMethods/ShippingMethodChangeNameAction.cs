using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShippingMethods
{
    public class ShippingMethodChangeNameAction : ShippingMethodUpdateAction
    {
        public string Name { get; set;}
    }
}
