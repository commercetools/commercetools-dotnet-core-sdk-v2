using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.CartDiscounts.PatternComponent))]
    [SubTypeDiscriminator("CountOnCustomLineItemUnits", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CountOnCustomLineItemUnits))]
    [SubTypeDiscriminator("CountOnLineItemUnits", typeof(commercetools.Sdk.Api.Models.CartDiscounts.CountOnLineItemUnits))]
    public partial interface IPatternComponent
    {
        string Type { get; set; }

        static commercetools.Sdk.Api.Models.CartDiscounts.CountOnCustomLineItemUnits CountOnCustomLineItemUnits(Action<commercetools.Sdk.Api.Models.CartDiscounts.CountOnCustomLineItemUnits> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CountOnCustomLineItemUnits();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.CartDiscounts.CountOnLineItemUnits CountOnLineItemUnits(Action<commercetools.Sdk.Api.Models.CartDiscounts.CountOnLineItemUnits> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.CartDiscounts.CountOnLineItemUnits();
            init?.Invoke(t);
            return t;
        }
    }
}
