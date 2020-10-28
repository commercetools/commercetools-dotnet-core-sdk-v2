using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class ReturnInfo : IReturnInfo
    {
        public List<IReturnItem> Items { get; set;}
        
        public string ReturnTrackingId { get; set;}
        
        public DateTime ReturnDate { get; set;}
    }
}
