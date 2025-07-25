using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountUpdateAction))]
    [SubTypeDiscriminator("addStore", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountAddStoreAction))]
    [SubTypeDiscriminator("changeCartPredicate", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeCartPredicateAction))]
    [SubTypeDiscriminator("changeIsActive", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeIsActiveAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeNameAction))]
    [SubTypeDiscriminator("changeRequiresDiscountCode", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeRequiresDiscountCodeAction))]
    [SubTypeDiscriminator("changeSortOrder", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeSortOrderAction))]
    [SubTypeDiscriminator("changeStackingMode", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeStackingModeAction))]
    [SubTypeDiscriminator("changeTarget", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeTargetAction))]
    [SubTypeDiscriminator("changeValue", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeValueAction))]
    [SubTypeDiscriminator("removeStore", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountRemoveStoreAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetCustomTypeAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetDescriptionAction))]
    [SubTypeDiscriminator("setDiscountGroup", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetDiscountGroupAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetKeyAction))]
    [SubTypeDiscriminator("setStores", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetStoresAction))]
    [SubTypeDiscriminator("setValidFrom", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAction))]
    [SubTypeDiscriminator("setValidFromAndUntil", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAndUntilAction))]
    [SubTypeDiscriminator("setValidUntil", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidUntilAction))]
    public partial interface ICartDiscountUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountAddStoreAction AddStore(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountAddStoreAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountAddStoreAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeCartPredicateAction ChangeCartPredicate(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeCartPredicateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeCartPredicateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeIsActiveAction ChangeIsActive(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeIsActiveAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeIsActiveAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeRequiresDiscountCodeAction ChangeRequiresDiscountCode(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeRequiresDiscountCodeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeRequiresDiscountCodeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeSortOrderAction ChangeSortOrder(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeSortOrderAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeSortOrderAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeStackingModeAction ChangeStackingMode(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeStackingModeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeStackingModeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeTargetAction ChangeTarget(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeTargetAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeTargetAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeValueAction ChangeValue(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeValueAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeValueAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountRemoveStoreAction RemoveStore(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountRemoveStoreAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountRemoveStoreAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetDiscountGroupAction SetDiscountGroup(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetDiscountGroupAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetDiscountGroupAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetStoresAction SetStores(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetStoresAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetStoresAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAction SetValidFrom(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAndUntilAction SetValidFromAndUntil(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAndUntilAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAndUntilAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidUntilAction SetValidUntil(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidUntilAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidUntilAction();
            init?.Invoke(t);
            return t;
        }
    }
}
