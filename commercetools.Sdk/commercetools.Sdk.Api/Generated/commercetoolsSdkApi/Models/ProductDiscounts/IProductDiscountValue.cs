using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValue))]
    [SubTypeDiscriminator("absolute", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsolute))]
    [SubTypeDiscriminator("external", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueExternal))]
    [SubTypeDiscriminator("relative", typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelative))]
    public partial interface IProductDiscountValue
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsolute Absolute(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsolute> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueAbsolute();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueExternal External(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueExternal> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueExternal();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelative Relative(Action<commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelative> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelative();
            init?.Invoke(t);
            return t;
        }
    }
}
