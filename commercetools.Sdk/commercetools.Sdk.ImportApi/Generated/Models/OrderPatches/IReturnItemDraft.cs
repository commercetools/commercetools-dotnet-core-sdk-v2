using commercetools.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.OrderPatches.ReturnItemDraft))]
    public partial interface IReturnItemDraft 
    {
        double Quantity { get; set;}
        
        string LineItemId { get; set;}
        
        string CustomLineItemId { get; set;}
        
        string Comment { get; set;}
        
        IReturnShipmentState ShipmentState { get; set;}
    }
}
