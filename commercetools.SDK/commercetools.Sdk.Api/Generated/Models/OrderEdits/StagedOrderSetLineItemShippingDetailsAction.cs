using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setLineItemShippingDetails")]
    public partial class StagedOrderSetLineItemShippingDetailsAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
        public StagedOrderSetLineItemShippingDetailsAction()
        { 
           this.Action = "setLineItemShippingDetails";
        }
    }
}
