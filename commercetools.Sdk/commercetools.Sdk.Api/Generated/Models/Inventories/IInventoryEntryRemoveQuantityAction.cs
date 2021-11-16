using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntryRemoveQuantityAction))]
    public partial interface IInventoryEntryRemoveQuantityAction : IInventoryEntryUpdateAction
    {
        long Quantity { get; set; }
    }
}
