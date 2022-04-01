using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountTarget))]
    [SubTypeDiscriminator("customLineItems", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountCustomLineItemsTarget))]
    [SubTypeDiscriminator("lineItems", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountLineItemsTarget))]
    [SubTypeDiscriminator("multiBuyCustomLineItems", typeof(commercetools.Sdk.Api.Models.CartDiscounts.MultiBuyCustomLineItemsTarget))]
    [SubTypeDiscriminator("multiBuyLineItems", typeof(commercetools.Sdk.Api.Models.CartDiscounts.MultiBuyLineItemsTarget))]
    [SubTypeDiscriminator("shipping", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountShippingCostTarget))]
    public partial interface ICartDiscountTarget
    {
        string Type { get; set; }
    }
}
