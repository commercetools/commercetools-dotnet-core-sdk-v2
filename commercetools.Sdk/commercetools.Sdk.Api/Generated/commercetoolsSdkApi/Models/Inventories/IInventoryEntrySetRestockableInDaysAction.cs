using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetRestockableInDaysAction))]
    public partial interface IInventoryEntrySetRestockableInDaysAction : IInventoryEntryUpdateAction
    {
        long? RestockableInDays { get; set; }

    }
}
