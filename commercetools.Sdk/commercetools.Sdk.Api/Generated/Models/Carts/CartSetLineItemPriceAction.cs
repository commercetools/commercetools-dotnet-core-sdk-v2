using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetLineItemPriceAction : ICartSetLineItemPriceAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IMoney ExternalPrice { get; set; }
        public CartSetLineItemPriceAction()
        {
            this.Action = "setLineItemPrice";
        }
    }
}
