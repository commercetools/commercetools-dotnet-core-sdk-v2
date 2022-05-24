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
    }
}
