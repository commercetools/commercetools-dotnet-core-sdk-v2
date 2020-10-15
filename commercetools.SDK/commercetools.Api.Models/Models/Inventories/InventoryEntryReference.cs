using commercetools.Api.Models.Common;
using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DiscriminatorValue("inventory-entry")]
    public partial class InventoryEntryReference : Reference
    {
        public InventoryEntry Obj { get; set;}
        public InventoryEntryReference()
        { 
           this.TypeId = "inventory-entry";
        }
    }
}
