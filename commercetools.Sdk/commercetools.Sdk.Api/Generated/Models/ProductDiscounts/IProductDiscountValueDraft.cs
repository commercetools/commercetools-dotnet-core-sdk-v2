using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueDraft))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsoluteDraft))]
    [SubTypeDiscriminator("external", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueExternalDraft))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelativeDraft))]
    public partial interface IProductDiscountValueDraft
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsoluteDraft Absolute(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsoluteDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsoluteDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueExternalDraft External(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueExternalDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueExternalDraft();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelativeDraft Relative(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelativeDraft> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelativeDraft();
            init?.Invoke(t);
            return t;
        }
    }
}
