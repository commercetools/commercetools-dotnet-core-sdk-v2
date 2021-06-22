using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntrySetExpectedDeliveryAction : IInventoryEntrySetExpectedDeliveryAction
    {
        public string Action { get; set;}
        
        public DateTime? ExpectedDelivery { get; set;}
        public InventoryEntrySetExpectedDeliveryAction()
        { 
           this.Action = "setExpectedDelivery";
        }
    }
}
