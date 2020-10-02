using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("importCustomLineItemState")]
    public partial class StagedOrderImportCustomLineItemStateAction : StagedOrderUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public List<ItemState> State { get; set;}
        public StagedOrderImportCustomLineItemStateAction()
        { 
           this.Action = "importCustomLineItemState";
        }
    }
}
