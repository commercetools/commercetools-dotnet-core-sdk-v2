using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("giftLineItem", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueGiftLineItemDraft))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueRelativeDraft))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueAbsoluteDraft))]
    public interface ICartDiscountValueDraft 
    {
        string Type { get; set;}
    }
}
