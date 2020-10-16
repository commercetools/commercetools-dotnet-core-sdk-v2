using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DiscriminatorValue("removeQuantity")]
    public partial class InventoryEntryRemoveQuantityAction : InventoryEntryUpdateAction
    {
        public long Quantity { get; set;}
        public InventoryEntryRemoveQuantityAction()
        { 
           this.Action = "removeQuantity";
        }
    }
}
