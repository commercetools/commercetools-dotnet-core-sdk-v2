using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderAddDeliveryAction : IOrderAddDeliveryAction
    {
        public string Action { get; set;}
        
        public List<IDeliveryItem> Items { get; set;}
        
        public IAddress Address { get; set;}
        
        public List<IParcelDraft> Parcels { get; set;}
        public OrderAddDeliveryAction()
        { 
           this.Action = "addDelivery";
        }
    }
}
