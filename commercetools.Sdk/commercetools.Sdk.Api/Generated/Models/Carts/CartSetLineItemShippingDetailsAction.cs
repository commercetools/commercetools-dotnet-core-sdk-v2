using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetLineItemShippingDetailsAction : ICartSetLineItemShippingDetailsAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
        public CartSetLineItemShippingDetailsAction()
        {
            this.Action = "setLineItemShippingDetails";
        }
    }
}
