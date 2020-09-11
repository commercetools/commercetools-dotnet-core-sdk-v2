using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderAddReturnInfoAction : OrderUpdateAction
    {
        public string ReturnTrackingId { get; set;}
        
        public List<ReturnItemDraft> Items { get; set;}
        
        public DateTime ReturnDate { get; set;}
    }
}
