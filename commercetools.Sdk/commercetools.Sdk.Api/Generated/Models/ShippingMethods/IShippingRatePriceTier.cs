using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.ShippingMethods.ShippingRatePriceTier))]
    [SubTypeDiscriminator("CartClassification", typeof(commercetools.Api.Models.ShippingMethods.CartClassificationTier))]
    [SubTypeDiscriminator("CartScore", typeof(commercetools.Api.Models.ShippingMethods.CartScoreTier))]
    [SubTypeDiscriminator("CartValue", typeof(commercetools.Api.Models.ShippingMethods.CartValueTier))]
    public partial interface IShippingRatePriceTier
    {
        IShippingRateTierType Type { get; set; }
    }
}
