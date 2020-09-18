using commercetools.Api.Models.Common;
using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [DiscriminatorValue("inventory-entry")]
    public class InventoryEntryReference : Reference
    {
        public InventoryEntry Obj { get; set;}
    }
}
