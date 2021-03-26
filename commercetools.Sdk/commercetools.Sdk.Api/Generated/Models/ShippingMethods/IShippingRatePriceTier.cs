using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("CartValue", typeof(commercetools.Api.Models.ShippingMethods.CartValueTier))]
    [SubTypeDiscriminator("CartScore", typeof(commercetools.Api.Models.ShippingMethods.CartScoreTier))]
    [SubTypeDiscriminator("CartClassification", typeof(commercetools.Api.Models.ShippingMethods.CartClassificationTier))]
    public partial interface IShippingRatePriceTier 
    {
        IShippingRateTierType Type { get; set;}
    }
}
