using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class ReturnItemDraft : IReturnItemDraft
    {
        public long Quantity { get; set;}
        
        public string LineItemId { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public string Comment { get; set;}
        
        public string ShipmentState { get; set;}
        
        [JsonIgnore]
        public ReturnShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ReturnShipmentState>();
    }
}
