using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryChangeQuantityAction))]
    public partial interface IInventoryEntryChangeQuantityAction : IInventoryEntryUpdateAction
    {
        long Quantity { get; set; }

    }
}
