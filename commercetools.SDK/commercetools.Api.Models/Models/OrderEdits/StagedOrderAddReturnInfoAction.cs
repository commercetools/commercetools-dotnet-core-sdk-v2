using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("addReturnInfo")]
    public partial class StagedOrderAddReturnInfoAction : StagedOrderUpdateAction
    {
        public string ReturnTrackingId { get; set;}
        
        public List<ReturnItemDraft> Items { get; set;}
        
        public DateTime ReturnDate { get; set;}
        public StagedOrderAddReturnInfoAction()
        { 
           this.Action = "addReturnInfo";
        }
    }
}
