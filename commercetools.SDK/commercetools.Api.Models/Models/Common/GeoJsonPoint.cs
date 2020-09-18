using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DiscriminatorValue("Point")]
    public class GeoJsonPoint : GeoJson
    {
        public List<double> Coordinates { get; set;}
    }
}
