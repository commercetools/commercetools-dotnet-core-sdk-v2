using commercetools.ImportApi.Models.OrderPatches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.OrderPatches
{
    public partial class ReturnItemDraft : IReturnItemDraft
    {
        public double Quantity { get; set;}
        
        public string LineItemId { get; set;}
        
        public string CustomLineItemId { get; set;}
        
        public string Comment { get; set;}
        
        public IReturnShipmentState ShipmentState { get; set;}
    }
}
