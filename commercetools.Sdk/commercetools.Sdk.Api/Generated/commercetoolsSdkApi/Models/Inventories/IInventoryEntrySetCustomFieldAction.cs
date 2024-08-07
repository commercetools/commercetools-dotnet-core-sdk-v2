using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetCustomFieldAction))]
    public partial interface IInventoryEntrySetCustomFieldAction : IInventoryEntryUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
