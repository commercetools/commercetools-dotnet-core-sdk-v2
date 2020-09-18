using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("addReturnInfo")]
    public class OrderAddReturnInfoAction : OrderUpdateAction
    {
        public string ReturnTrackingId { get; set;}
        
        public List<ReturnItemDraft> Items { get; set;}
        
        public DateTime ReturnDate { get; set;}
    }
}
