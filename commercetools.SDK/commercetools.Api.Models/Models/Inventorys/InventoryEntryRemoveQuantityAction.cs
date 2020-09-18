using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [DiscriminatorValue("removeQuantity")]
    public class InventoryEntryRemoveQuantityAction : InventoryEntryUpdateAction
    {
        public long Quantity { get; set;}
    }
}
