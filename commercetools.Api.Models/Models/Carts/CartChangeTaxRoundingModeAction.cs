using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class CartChangeTaxRoundingModeAction : CartUpdateAction
    {
        public RoundingMode TaxRoundingMode { get; set;}
    }
}
