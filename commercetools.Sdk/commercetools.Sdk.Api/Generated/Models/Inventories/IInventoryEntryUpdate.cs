using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryUpdate))]
    public partial interface IInventoryEntryUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IInventoryEntryUpdate, IInventoryEntryUpdateAction>
    {
        new long Version { get; set; }
        new List<IInventoryEntryUpdateAction> Actions { get; set; }

    }
}
