using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DiscriminatorValue("Point")]
    public partial class GeoJsonPoint : GeoJson
    {
        public List<double> Coordinates { get; set;}
        public GeoJsonPoint()
        { 
           this.Type = "Point";
        }
    }
}
