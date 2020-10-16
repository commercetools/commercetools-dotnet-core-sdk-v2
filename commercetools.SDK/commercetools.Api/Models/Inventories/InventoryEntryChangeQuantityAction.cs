using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DiscriminatorValue("changeQuantity")]
    public partial class InventoryEntryChangeQuantityAction : InventoryEntryUpdateAction
    {
        public long Quantity { get; set;}
        public InventoryEntryChangeQuantityAction()
        { 
           this.Action = "changeQuantity";
        }
    }
}
