using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryAddQuantityAction))]
    public partial interface IInventoryEntryAddQuantityAction : IInventoryEntryUpdateAction
    {
        long Quantity { get; set; }
    }
}
