using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    public class GeoJsonPoint : GeoJson
    {
        public List<double> Coordinates { get; set;}
    }
}
