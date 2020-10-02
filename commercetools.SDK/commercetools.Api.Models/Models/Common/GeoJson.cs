using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [Discriminator(nameof(Type))]
    public abstract partial class GeoJson 
    {
        public string Type { get; set;}
    }
}
