using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("importLineItemState")]
    public partial class StagedOrderImportLineItemStateAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public List<ItemState> State { get; set;}
        public StagedOrderImportLineItemStateAction()
        { 
           this.Action = "importLineItemState";
        }
    }
}
