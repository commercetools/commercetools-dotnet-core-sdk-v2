using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryChangeQuantityAction))]
    public partial interface IInventoryEntryChangeQuantityAction : IInventoryEntryUpdateAction
    {
        long Quantity { get; set; }

    }
}
