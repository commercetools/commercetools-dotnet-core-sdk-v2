using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Inventories.InventoryEntryUpdateAction))]
    [SubTypeDiscriminator("addQuantity", typeof(commercetools.Api.Models.Inventories.InventoryEntryAddQuantityAction))]
    [SubTypeDiscriminator("changeQuantity", typeof(commercetools.Api.Models.Inventories.InventoryEntryChangeQuantityAction))]
    [SubTypeDiscriminator("removeQuantity", typeof(commercetools.Api.Models.Inventories.InventoryEntryRemoveQuantityAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.Inventories.InventoryEntrySetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.Inventories.InventoryEntrySetCustomTypeAction))]
    [SubTypeDiscriminator("setExpectedDelivery", typeof(commercetools.Api.Models.Inventories.InventoryEntrySetExpectedDeliveryAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.Inventories.InventoryEntrySetKeyAction))]
    [SubTypeDiscriminator("setRestockableInDays", typeof(commercetools.Api.Models.Inventories.InventoryEntrySetRestockableInDaysAction))]
    [SubTypeDiscriminator("setSupplyChannel", typeof(commercetools.Api.Models.Inventories.InventoryEntrySetSupplyChannelAction))]
    public partial interface IInventoryEntryUpdateAction
    {
        string Action { get; set; }
    }
}
