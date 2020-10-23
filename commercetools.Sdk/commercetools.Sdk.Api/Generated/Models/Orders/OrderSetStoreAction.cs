using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public  partial class OrderSetStoreAction : IOrderSetStoreAction
    {
        public string Action { get; set;}
        
        public IStoreResourceIdentifier Store { get; set;}
        public OrderSetStoreAction()
        { 
           this.Action = "setStore";
        }
    }
}
