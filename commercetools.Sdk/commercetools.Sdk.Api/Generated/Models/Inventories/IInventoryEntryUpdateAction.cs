using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Inventories
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryUpdateAction))]
    [SubTypeDiscriminator("addQuantity", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryAddQuantityAction))]
    [SubTypeDiscriminator("changeQuantity", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryChangeQuantityAction))]
    [SubTypeDiscriminator("removeQuantity", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntryRemoveQuantityAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetCustomTypeAction))]
    [SubTypeDiscriminator("setExpectedDelivery", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetExpectedDeliveryAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetKeyAction))]
    [SubTypeDiscriminator("setRestockableInDays", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetRestockableInDaysAction))]
    [SubTypeDiscriminator("setSupplyChannel", typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetSupplyChannelAction))]
    public partial interface IInventoryEntryUpdateAction
    {
        string Action { get; set; }
    }
}
