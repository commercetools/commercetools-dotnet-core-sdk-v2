using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryUpdate))]
    public partial interface IInventoryEntryUpdate
    {
        long Version { get; set; }

        List<IInventoryEntryUpdateAction> Actions { get; set; }
    }
}
