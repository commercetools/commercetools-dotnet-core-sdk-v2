using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setCustomLineItemShippingDetails")]
    public partial class OrderSetCustomLineItemShippingDetailsAction : OrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
        public OrderSetCustomLineItemShippingDetailsAction()
        { 
           this.Action = "setCustomLineItemShippingDetails";
        }
    }
}
