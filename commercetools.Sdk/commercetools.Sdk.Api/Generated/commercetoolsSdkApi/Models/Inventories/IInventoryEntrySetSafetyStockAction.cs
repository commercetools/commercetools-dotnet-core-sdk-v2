using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetSafetyStockAction))]
    public partial interface IInventoryEntrySetSafetyStockAction : IInventoryEntryUpdateAction
    {
        int? Quantity { get; set; }

    }
}
