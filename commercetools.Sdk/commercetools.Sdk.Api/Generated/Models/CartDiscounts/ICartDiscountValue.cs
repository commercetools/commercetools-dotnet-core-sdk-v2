using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValue))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsolute))]
    [SubTypeDiscriminator("fixed", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixed))]
    [SubTypeDiscriminator("giftLineItem", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItem))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelative))]
    public partial interface ICartDiscountValue
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsolute Absolute(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsolute> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsolute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixed Fixed(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixed> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixed();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItem GiftLineItem(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItem> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItem();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelative Relative(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelative> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelative();
            init?.Invoke(t);
            return t;
        }
    }
}
