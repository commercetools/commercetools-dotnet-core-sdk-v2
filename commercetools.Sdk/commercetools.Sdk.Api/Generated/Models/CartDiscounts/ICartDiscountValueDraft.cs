using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueDraft))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsoluteDraft))]
    [SubTypeDiscriminator("fixed", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixedDraft))]
    [SubTypeDiscriminator("giftLineItem", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItemDraft))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelativeDraft))]
    public partial interface ICartDiscountValueDraft
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsoluteDraft Absolute(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsoluteDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueAbsoluteDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixedDraft Fixed(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixedDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueFixedDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItemDraft GiftLineItem(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItemDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueGiftLineItemDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelativeDraft Relative(Action<commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelativeDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountValueRelativeDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
