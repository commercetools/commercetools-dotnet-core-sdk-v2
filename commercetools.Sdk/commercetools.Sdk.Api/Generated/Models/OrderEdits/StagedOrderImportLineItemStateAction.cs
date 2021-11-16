using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderImportLineItemStateAction : IStagedOrderImportLineItemStateAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public List<IItemState> State { get; set;}
        public StagedOrderImportLineItemStateAction()
        { 
           this.Action = "importLineItemState";
        }
    }
}
