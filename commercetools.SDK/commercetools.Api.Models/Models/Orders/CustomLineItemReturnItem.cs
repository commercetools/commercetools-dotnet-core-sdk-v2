using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("CustomLineItemReturnItem")]
    public class CustomLineItemReturnItem : ReturnItem
    {
        public string CustomLineItemId { get; set;}
    }
}
