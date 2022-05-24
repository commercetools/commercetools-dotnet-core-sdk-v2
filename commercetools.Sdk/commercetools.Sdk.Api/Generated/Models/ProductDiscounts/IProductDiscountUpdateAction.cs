using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountUpdateAction))]
    [SubTypeDiscriminator("changeIsActive", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeIsActiveAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeNameAction))]
    [SubTypeDiscriminator("changePredicate", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangePredicateAction))]
    [SubTypeDiscriminator("changeSortOrder", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeSortOrderAction))]
    [SubTypeDiscriminator("changeValue", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountChangeValueAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetDescriptionAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetKeyAction))]
    [SubTypeDiscriminator("setValidFrom", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAction))]
    [SubTypeDiscriminator("setValidFromAndUntil", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidFromAndUntilAction))]
    [SubTypeDiscriminator("setValidUntil", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetValidUntilAction))]
    public partial interface IProductDiscountUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IProductDiscountUpdateAction>
    {
        new string Action { get; set; }
    }
}
