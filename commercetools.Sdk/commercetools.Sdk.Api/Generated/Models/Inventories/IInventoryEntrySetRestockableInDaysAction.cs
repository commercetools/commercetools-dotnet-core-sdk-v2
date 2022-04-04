using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetRestockableInDaysAction))]
    public partial interface IInventoryEntrySetRestockableInDaysAction : IInventoryEntryUpdateAction
    {
        long? RestockableInDays { get; set; }
    }
}
