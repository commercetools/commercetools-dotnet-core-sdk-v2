using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
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
        new string Action { get; set; }

        static commercetools.Sdk.Api.Models.Inventories.InventoryEntryAddQuantityAction AddQuantity(Action<commercetools.Sdk.Api.Models.Inventories.InventoryEntryAddQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Inventories.InventoryEntryAddQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Inventories.InventoryEntryChangeQuantityAction ChangeQuantity(Action<commercetools.Sdk.Api.Models.Inventories.InventoryEntryChangeQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Inventories.InventoryEntryChangeQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Inventories.InventoryEntryRemoveQuantityAction RemoveQuantity(Action<commercetools.Sdk.Api.Models.Inventories.InventoryEntryRemoveQuantityAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Inventories.InventoryEntryRemoveQuantityAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetExpectedDeliveryAction SetExpectedDelivery(Action<commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetExpectedDeliveryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetExpectedDeliveryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetRestockableInDaysAction SetRestockableInDays(Action<commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetRestockableInDaysAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetRestockableInDaysAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetSupplyChannelAction SetSupplyChannel(Action<commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetSupplyChannelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetSupplyChannelAction();
            init?.Invoke(t);
            return t;
        }
    }
}
