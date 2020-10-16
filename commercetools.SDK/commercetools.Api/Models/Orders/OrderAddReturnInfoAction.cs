using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("addReturnInfo")]
    public partial class OrderAddReturnInfoAction : OrderUpdateAction
    {
        public string ReturnTrackingId { get; set;}
        
        public List<ReturnItemDraft> Items { get; set;}
        
        public DateTime ReturnDate { get; set;}
        public OrderAddReturnInfoAction()
        { 
           this.Action = "addReturnInfo";
        }
    }
}
