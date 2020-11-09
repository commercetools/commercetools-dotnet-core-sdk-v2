using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.ReturnItemDraft))]
    public partial interface IReturnItemDraft 
    {
        long Quantity { get; set;}
        
        string LineItemId { get; set;}
        
        string CustomLineItemId { get; set;}
        
        string Comment { get; set;}
        
        string ShipmentState { get; set;}
        
        ReturnShipmentState ShipmentStateAsEnum { get; }
    }
}
