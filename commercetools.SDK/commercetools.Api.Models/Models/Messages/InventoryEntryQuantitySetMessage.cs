using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("InventoryEntryQuantitySet")]
    public class InventoryEntryQuantitySetMessage : Message
    {
        public long OldQuantityOnStock { get; set;}
        
        public long NewQuantityOnStock { get; set;}
        
        public long OldAvailableQuantity { get; set;}
        
        public long NewAvailableQuantity { get; set;}
    }
}
