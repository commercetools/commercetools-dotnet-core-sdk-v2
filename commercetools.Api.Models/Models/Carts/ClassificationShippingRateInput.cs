using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class ClassificationShippingRateInput : ShippingRateInput
    {
        public string Key { get; set;}
        
        public LocalizedString Label { get; set;}
    }
}
