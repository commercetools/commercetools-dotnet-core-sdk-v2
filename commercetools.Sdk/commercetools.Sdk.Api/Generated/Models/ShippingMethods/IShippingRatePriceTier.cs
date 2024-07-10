using commercetools.Sdk.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingRatePriceTier))]
    [SubTypeDiscriminator("CartClassification", typeof(commercetools.Sdk.Api.Models.ShippingMethods.CartClassificationTier))]
    [SubTypeDiscriminator("CartScore", typeof(commercetools.Sdk.Api.Models.ShippingMethods.CartScoreTier))]
    [SubTypeDiscriminator("CartValue", typeof(commercetools.Sdk.Api.Models.ShippingMethods.CartValueTier))]
    public partial interface IShippingRatePriceTier
    {
        IShippingRateTierType Type { get; set; }

        static commercetools.Sdk.Api.Models.ShippingMethods.CartClassificationTier CartClassification(Action<commercetools.Sdk.Api.Models.ShippingMethods.CartClassificationTier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.CartClassificationTier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.CartScoreTier CartScore(Action<commercetools.Sdk.Api.Models.ShippingMethods.CartScoreTier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.CartScoreTier();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ShippingMethods.CartValueTier CartValue(Action<commercetools.Sdk.Api.Models.ShippingMethods.CartValueTier> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ShippingMethods.CartValueTier();
            init?.Invoke(t);
            return t;
        }
    }
}
