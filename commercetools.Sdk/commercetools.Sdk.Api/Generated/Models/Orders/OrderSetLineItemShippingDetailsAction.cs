using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetLineItemShippingDetailsAction : IOrderSetLineItemShippingDetailsAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
        public OrderSetLineItemShippingDetailsAction()
        {
            this.Action = "setLineItemShippingDetails";
        }
    }
}
