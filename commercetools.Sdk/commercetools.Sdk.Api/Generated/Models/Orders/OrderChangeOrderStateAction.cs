using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderChangeOrderStateAction : IOrderChangeOrderStateAction
    {
        public string Action { get; set;}
        
        public IOrderState OrderState { get; set;}
        public OrderChangeOrderStateAction()
        { 
           this.Action = "changeOrderState";
        }
    }
}
