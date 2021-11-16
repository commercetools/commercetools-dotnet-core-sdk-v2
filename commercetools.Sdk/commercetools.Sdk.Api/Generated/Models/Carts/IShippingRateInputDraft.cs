using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Carts.ShippingRateInputDraft))]
    [SubTypeDiscriminator("Classification", typeof(commercetools.Api.Models.Carts.ClassificationShippingRateInputDraft))]
    [SubTypeDiscriminator("Score", typeof(commercetools.Api.Models.Carts.ScoreShippingRateInputDraft))]
    public partial interface IShippingRateInputDraft 
    {
        string Type { get; set;}
    }
}
