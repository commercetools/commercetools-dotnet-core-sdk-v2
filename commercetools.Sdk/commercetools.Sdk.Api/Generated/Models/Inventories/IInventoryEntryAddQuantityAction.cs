using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntryAddQuantityAction))]
    public partial interface IInventoryEntryAddQuantityAction : IInventoryEntryUpdateAction
    {
        long Quantity { get; set; }
    }
}
