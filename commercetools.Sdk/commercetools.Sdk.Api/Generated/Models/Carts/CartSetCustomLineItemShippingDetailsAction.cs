using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCustomLineItemShippingDetailsAction : ICartSetCustomLineItemShippingDetailsAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
        public CartSetCustomLineItemShippingDetailsAction()
        {
            this.Action = "setCustomLineItemShippingDetails";
        }
    }
}
