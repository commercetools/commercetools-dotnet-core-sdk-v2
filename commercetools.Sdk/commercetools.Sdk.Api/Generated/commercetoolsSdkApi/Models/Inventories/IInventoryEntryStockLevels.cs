using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryStockLevels))]
    public partial interface IInventoryEntryStockLevels
    {
        int? ReorderPoint { get; set; }

        int? SafetyStock { get; set; }

    }
}
