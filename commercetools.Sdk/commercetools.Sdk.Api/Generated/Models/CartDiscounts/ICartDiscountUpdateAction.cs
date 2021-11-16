using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountUpdateAction))]
    [SubTypeDiscriminator("changeCartPredicate", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeCartPredicateAction))]
    [SubTypeDiscriminator("changeIsActive", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeIsActiveAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeNameAction))]
    [SubTypeDiscriminator("changeRequiresDiscountCode", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeRequiresDiscountCodeAction))]
    [SubTypeDiscriminator("changeSortOrder", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeSortOrderAction))]
    [SubTypeDiscriminator("changeStackingMode", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeStackingModeAction))]
    [SubTypeDiscriminator("changeTarget", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeTargetAction))]
    [SubTypeDiscriminator("changeValue", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeValueAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetCustomTypeAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetKeyAction))]
    [SubTypeDiscriminator("setValidFrom", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetValidFromAction))]
    [SubTypeDiscriminator("setValidFromAndUntil", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetValidFromAndUntilAction))]
    [SubTypeDiscriminator("setValidUntil", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetValidUntilAction))]
    public partial interface ICartDiscountUpdateAction 
    {
        string Action { get; set;}
    }
}
