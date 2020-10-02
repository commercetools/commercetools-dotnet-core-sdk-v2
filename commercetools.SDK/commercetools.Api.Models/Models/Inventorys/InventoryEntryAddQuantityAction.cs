using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [DiscriminatorValue("addQuantity")]
    public partial class InventoryEntryAddQuantityAction : InventoryEntryUpdateAction
    {
        public long Quantity { get; set;}
        public InventoryEntryAddQuantityAction()
        { 
           this.Action = "addQuantity";
        }
    }
}
