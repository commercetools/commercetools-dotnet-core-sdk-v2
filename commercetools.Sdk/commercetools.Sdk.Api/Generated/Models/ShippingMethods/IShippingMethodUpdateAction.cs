using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodUpdateAction))]
    [SubTypeDiscriminator("addShippingRate", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodAddShippingRateAction))]
    [SubTypeDiscriminator("addZone", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodAddZoneAction))]
    [SubTypeDiscriminator("changeIsDefault", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeIsDefaultAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeNameAction))]
    [SubTypeDiscriminator("changeTaxCategory", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeTaxCategoryAction))]
    [SubTypeDiscriminator("removeShippingRate", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodRemoveShippingRateAction))]
    [SubTypeDiscriminator("removeZone", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodRemoveZoneAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetCustomTypeAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetKeyAction))]
    [SubTypeDiscriminator("setLocalizedDescription", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetLocalizedDescriptionAction))]
    [SubTypeDiscriminator("setLocalizedName", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetLocalizedNameAction))]
    [SubTypeDiscriminator("setPredicate", typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetPredicateAction))]
    public partial interface IShippingMethodUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IShippingMethodUpdateAction>
    {
        new string Action { get; set; }

        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodAddShippingRateAction AddShippingRate(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodAddShippingRateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodAddShippingRateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodAddZoneAction AddZone(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodAddZoneAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodAddZoneAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeIsDefaultAction ChangeIsDefault(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeIsDefaultAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeIsDefaultAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeNameAction ChangeName(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeTaxCategoryAction ChangeTaxCategory(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeTaxCategoryAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeTaxCategoryAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodRemoveShippingRateAction RemoveShippingRate(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodRemoveShippingRateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodRemoveShippingRateAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodRemoveZoneAction RemoveZone(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodRemoveZoneAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodRemoveZoneAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetCustomFieldAction SetCustomField(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetCustomFieldAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetCustomFieldAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetCustomTypeAction SetCustomType(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetCustomTypeAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetCustomTypeAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetDescriptionAction SetDescription(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetKeyAction SetKey(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetKeyAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetKeyAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetLocalizedDescriptionAction SetLocalizedDescription(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetLocalizedDescriptionAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetLocalizedDescriptionAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetLocalizedNameAction SetLocalizedName(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetLocalizedNameAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetLocalizedNameAction();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetPredicateAction SetPredicate(Action<commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetPredicateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetPredicateAction();
            init?.Invoke(t);
            return t;
        }
    }
}
