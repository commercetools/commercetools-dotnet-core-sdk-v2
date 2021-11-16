using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntrySetCustomFieldAction))]
    public partial interface IInventoryEntrySetCustomFieldAction : IInventoryEntryUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
