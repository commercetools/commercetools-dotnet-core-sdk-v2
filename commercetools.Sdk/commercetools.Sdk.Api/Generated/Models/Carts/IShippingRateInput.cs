using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("Classification", typeof(commercetools.Api.Models.Carts.ClassificationShippingRateInput))]
    [SubTypeDiscriminator("Score", typeof(commercetools.Api.Models.Carts.ScoreShippingRateInput))]
    public partial interface IShippingRateInput 
    {
        string Type { get; set;}
    }
}
