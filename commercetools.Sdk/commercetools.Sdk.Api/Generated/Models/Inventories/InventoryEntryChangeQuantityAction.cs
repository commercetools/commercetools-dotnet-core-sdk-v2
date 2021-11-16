using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntryChangeQuantityAction : IInventoryEntryChangeQuantityAction
    {
        public string Action { get; set;}
        
        public long Quantity { get; set;}
        public InventoryEntryChangeQuantityAction()
        { 
           this.Action = "changeQuantity";
        }
    }
}
