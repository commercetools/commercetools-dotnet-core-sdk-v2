using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("Score", typeof(commercetools.Api.Models.Carts.ScoreShippingRateInputDraft))]
    [SubTypeDiscriminator("Classification", typeof(commercetools.Api.Models.Carts.ClassificationShippingRateInputDraft))]
    public interface IShippingRateInputDraft 
    {
        string Type { get; set;}
    }
}
