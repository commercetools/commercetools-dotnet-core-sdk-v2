using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setOrderNumber")]
    public partial class OrderSetOrderNumberAction : OrderUpdateAction
    {
        public string OrderNumber { get; set;}
        public OrderSetOrderNumberAction()
        { 
           this.Action = "setOrderNumber";
        }
    }
}
