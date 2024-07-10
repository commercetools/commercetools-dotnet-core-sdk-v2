using commercetools.Sdk.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntryAddQuantityAction : IInventoryEntryAddQuantityAction
    {
        public string Action { get; set; }

        public long Quantity { get; set; }
        public InventoryEntryAddQuantityAction()
        {
            this.Action = "addQuantity";
        }
    }
}
