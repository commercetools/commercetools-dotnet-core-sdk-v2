using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueAbsolute))]
    [SubTypeDiscriminator("giftLineItem", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueGiftLineItem))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueRelative))]
    public interface ICartDiscountValue 
    {
        string Type { get; set;}
    }
}
