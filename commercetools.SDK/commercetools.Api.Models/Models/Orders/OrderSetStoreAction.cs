using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setStore")]
    public partial class OrderSetStoreAction : OrderUpdateAction
    {
        public StoreResourceIdentifier Store { get; set;}
        public OrderSetStoreAction()
        { 
           this.Action = "setStore";
        }
    }
}
