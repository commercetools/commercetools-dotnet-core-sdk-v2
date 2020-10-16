using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("removeLineItem")]
    public partial class StagedOrderRemoveLineItemAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public double Quantity { get; set;}
        
        public Money ExternalPrice { get; set;}
        
        public ExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetailsToRemove { get; set;}
        public StagedOrderRemoveLineItemAction()
        { 
           this.Action = "removeLineItem";
        }
    }
}
