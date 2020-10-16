using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("InventoryEntryQuantitySet")]
    public partial class InventoryEntryQuantitySetMessagePayload : MessagePayload
    {
        public long OldQuantityOnStock { get; set;}
        
        public long NewQuantityOnStock { get; set;}
        
        public long OldAvailableQuantity { get; set;}
        
        public long NewAvailableQuantity { get; set;}
        public InventoryEntryQuantitySetMessagePayload()
        { 
           this.Type = "InventoryEntryQuantitySet";
        }
    }
}
