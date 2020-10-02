using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("LineItemReturnItem")]
    public partial class LineItemReturnItem : ReturnItem
    {
        public string LineItemId { get; set;}
        public LineItemReturnItem()
        { 
           this.Type = "LineItemReturnItem";
        }
    }
}
