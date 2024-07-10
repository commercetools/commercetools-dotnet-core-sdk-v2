using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetLineItemShippingDetailsAction : IOrderSetLineItemShippingDetailsAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
        public OrderSetLineItemShippingDetailsAction()
        {
            this.Action = "setLineItemShippingDetails";
        }
    }
}
