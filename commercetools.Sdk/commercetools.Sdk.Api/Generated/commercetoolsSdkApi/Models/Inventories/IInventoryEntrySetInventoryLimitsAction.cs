using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetInventoryLimitsAction))]
    public partial interface IInventoryEntrySetInventoryLimitsAction : IInventoryEntryUpdateAction
    {
        long? MinCartQuantity { get; set; }

        long? MaxCartQuantity { get; set; }

    }
}
