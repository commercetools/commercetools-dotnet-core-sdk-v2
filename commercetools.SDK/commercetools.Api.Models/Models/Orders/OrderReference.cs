using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("order")]
    public partial class OrderReference : Reference
    {
        public Order Obj { get; set;}
        public OrderReference()
        { 
           this.TypeId = "order";
        }
    }
}
