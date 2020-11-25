using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("CartScore", typeof(commercetools.Api.Models.Projects.CartScoreType))]
    [SubTypeDiscriminator("CartValue", typeof(commercetools.Api.Models.Projects.CartValueType))]
    [SubTypeDiscriminator("CartClassification", typeof(commercetools.Api.Models.Projects.CartClassificationType))]
    public partial interface IShippingRateInputType 
    {
        string Type { get; set;}
        
        ShippingRateTierType TypeAsEnum { get; }
    }
}
