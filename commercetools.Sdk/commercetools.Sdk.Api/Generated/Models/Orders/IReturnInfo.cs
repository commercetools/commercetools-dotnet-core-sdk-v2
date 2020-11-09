using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.ReturnInfo))]
    public partial interface IReturnInfo 
    {
        List<IReturnItem> Items { get; set;}
        
        string ReturnTrackingId { get; set;}
        
        DateTime ReturnDate { get; set;}
    }
}
