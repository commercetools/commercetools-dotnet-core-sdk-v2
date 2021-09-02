using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetShippingRateInputAction : ICartSetShippingRateInputAction
    {
        public string Action { get; set; }

        public IShippingRateInputDraft ShippingRateInput { get; set; }
        public CartSetShippingRateInputAction()
        {
            this.Action = "setShippingRateInput";
        }
    }
}
