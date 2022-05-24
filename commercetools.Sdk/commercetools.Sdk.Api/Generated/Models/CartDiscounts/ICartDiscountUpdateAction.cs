using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountUpdateAction))]
    [SubTypeDiscriminator("changeCartPredicate", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeCartPredicateAction))]
    [SubTypeDiscriminator("changeIsActive", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeIsActiveAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeNameAction))]
    [SubTypeDiscriminator("changeRequiresDiscountCode", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeRequiresDiscountCodeAction))]
    [SubTypeDiscriminator("changeSortOrder", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeSortOrderAction))]
    [SubTypeDiscriminator("changeStackingMode", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeStackingModeAction))]
    [SubTypeDiscriminator("changeTarget", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeTargetAction))]
    [SubTypeDiscriminator("changeValue", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeValueAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetCustomTypeAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetKeyAction))]
    [SubTypeDiscriminator("setValidFrom", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAction))]
    [SubTypeDiscriminator("setValidFromAndUntil", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidFromAndUntilAction))]
    [SubTypeDiscriminator("setValidUntil", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidUntilAction))]
    public partial interface ICartDiscountUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<ICartDiscountUpdateAction>
    {
        new string Action { get; set; }
    }
}
