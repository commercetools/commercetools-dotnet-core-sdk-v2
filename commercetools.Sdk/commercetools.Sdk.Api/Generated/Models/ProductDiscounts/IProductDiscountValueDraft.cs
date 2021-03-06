using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueAbsoluteDraft))]
    [SubTypeDiscriminator("external", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueExternalDraft))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueRelativeDraft))]
    public partial interface IProductDiscountValueDraft 
    {
        string Type { get; set;}
    }
}
