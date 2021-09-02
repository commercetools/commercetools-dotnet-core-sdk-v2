using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntryChangeQuantityAction))]
    public partial interface IInventoryEntryChangeQuantityAction : IInventoryEntryUpdateAction
    {
        long Quantity { get; set; }
    }
}
