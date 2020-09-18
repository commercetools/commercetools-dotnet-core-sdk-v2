using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [DiscriminatorValue("changeQuantity")]
    public class InventoryEntryChangeQuantityAction : InventoryEntryUpdateAction
    {
        public long Quantity { get; set;}
    }
}
