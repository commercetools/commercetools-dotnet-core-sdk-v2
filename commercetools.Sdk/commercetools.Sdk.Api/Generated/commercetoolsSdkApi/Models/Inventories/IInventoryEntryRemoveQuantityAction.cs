using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryRemoveQuantityAction))]
    public partial interface IInventoryEntryRemoveQuantityAction : IInventoryEntryUpdateAction
    {
        long Quantity { get; set; }

    }
}
