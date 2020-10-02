using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("importLineItemState")]
    public partial class OrderImportLineItemStateAction : OrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public List<ItemState> State { get; set;}
        public OrderImportLineItemStateAction()
        { 
           this.Action = "importLineItemState";
        }
    }
}
