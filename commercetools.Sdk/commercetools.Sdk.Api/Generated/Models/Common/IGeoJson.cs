using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("Point", typeof(commercetools.Api.Models.Common.GeoJsonPoint))]
    public interface IGeoJson 
    {
        string Type { get; set;}
    }
}
