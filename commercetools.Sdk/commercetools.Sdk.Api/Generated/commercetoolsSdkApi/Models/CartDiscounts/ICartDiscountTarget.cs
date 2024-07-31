using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountTarget))]
    [SubTypeDiscriminator("customLineItems", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountCustomLineItemsTarget))]
    [SubTypeDiscriminator("lineItems", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountLineItemsTarget))]
    [SubTypeDiscriminator("multiBuyCustomLineItems", typeof(commercetools.Sdk.Api.Models.CartDiscounts.MultiBuyCustomLineItemsTarget))]
    [SubTypeDiscriminator("multiBuyLineItems", typeof(commercetools.Sdk.Api.Models.CartDiscounts.MultiBuyLineItemsTarget))]
    [SubTypeDiscriminator("shipping", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountShippingCostTarget))]
    [SubTypeDiscriminator("totalPrice", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountTotalPriceTarget))]
    public partial interface ICartDiscountTarget
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountCustomLineItemsTarget CustomLineItems(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountCustomLineItemsTarget> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountCustomLineItemsTarget();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountLineItemsTarget LineItems(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountLineItemsTarget> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountLineItemsTarget();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.MultiBuyCustomLineItemsTarget MultiBuyCustomLineItems(Action<commercetools.Sdk.Api.Models.CartDiscounts.MultiBuyCustomLineItemsTarget> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.MultiBuyCustomLineItemsTarget();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.MultiBuyLineItemsTarget MultiBuyLineItems(Action<commercetools.Sdk.Api.Models.CartDiscounts.MultiBuyLineItemsTarget> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.MultiBuyLineItemsTarget();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountShippingCostTarget Shipping(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountShippingCostTarget> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountShippingCostTarget();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountTotalPriceTarget TotalPrice(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountTotalPriceTarget> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountTotalPriceTarget();
            init?.Invoke(t);
            return t;
        }
    }
}
