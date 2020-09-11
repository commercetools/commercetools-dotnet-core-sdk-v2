using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class ScoreShippingRateInput : ShippingRateInput
    {
        public double Score { get; set;}
    }
}
