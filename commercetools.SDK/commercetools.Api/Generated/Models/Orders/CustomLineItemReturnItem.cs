using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("CustomLineItemReturnItem")]
    public partial class CustomLineItemReturnItem : ReturnItem
    {
        public string CustomLineItemId { get; set;}
        public CustomLineItemReturnItem()
        { 
           this.Type = "CustomLineItemReturnItem";
        }
    }
}
