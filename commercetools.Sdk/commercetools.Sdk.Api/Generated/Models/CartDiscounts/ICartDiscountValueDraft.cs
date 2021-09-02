using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueDraft))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueAbsoluteDraft))]
    [SubTypeDiscriminator("fixed", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueFixedDraft))]
    [SubTypeDiscriminator("giftLineItem", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueGiftLineItemDraft))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueRelativeDraft))]
    public partial interface ICartDiscountValueDraft
    {
        string Type { get; set; }
    }
}
