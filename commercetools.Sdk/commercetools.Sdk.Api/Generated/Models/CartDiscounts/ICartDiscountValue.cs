using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValue))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueAbsolute))]
    [SubTypeDiscriminator("fixed", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueFixed))]
    [SubTypeDiscriminator("giftLineItem", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueGiftLineItem))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountValueRelative))]
    public partial interface ICartDiscountValue 
    {
        string Type { get; set;}
    }
}
