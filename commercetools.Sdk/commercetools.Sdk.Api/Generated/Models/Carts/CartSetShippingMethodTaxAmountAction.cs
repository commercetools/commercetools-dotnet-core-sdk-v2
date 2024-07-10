using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetShippingMethodTaxAmountAction : ICartSetShippingMethodTaxAmountAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
        public CartSetShippingMethodTaxAmountAction()
        {
            this.Action = "setShippingMethodTaxAmount";
        }
    }
}
