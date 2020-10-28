using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntrySetRestockableInDaysAction : IInventoryEntrySetRestockableInDaysAction
    {
        public string Action { get; set;}
        
        public long? RestockableInDays { get; set;}
        public InventoryEntrySetRestockableInDaysAction()
        { 
           this.Action = "setRestockableInDays";
        }
    }
}
