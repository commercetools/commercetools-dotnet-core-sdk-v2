using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntrySetRestockableInDaysAction))]
    public partial interface IInventoryEntrySetRestockableInDaysAction : IInventoryEntryUpdateAction
    {
        long? RestockableInDays { get; set;}
    }
}
