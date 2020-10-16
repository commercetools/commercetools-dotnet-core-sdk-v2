using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("importCustomLineItemState")]
    public partial class OrderImportCustomLineItemStateAction : OrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public List<ItemState> State { get; set;}
        public OrderImportCustomLineItemStateAction()
        { 
           this.Action = "importCustomLineItemState";
        }
    }
}
