using System;
using System.Collections.Generic;


namespace commercetools.Api.Models.Orders
{
    public partial class ReturnInfo : IReturnInfo
    {
        public List<IReturnItem> Items { get; set;}
        
        public string ReturnTrackingId { get; set;}
        
        public DateTime? ReturnDate { get; set;}
    }
}
