using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Orders
{
    public partial class ReturnInfo 
    {
        public List<ReturnItem> Items { get; set;}
        
        public string ReturnTrackingId { get; set;}
        
        public DateTime ReturnDate { get; set;}
    }
}
