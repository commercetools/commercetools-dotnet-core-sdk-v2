using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class GeoJsonPoint : IGeoJsonPoint
    {
        public string Type { get; set; }

        public List<double> Coordinates { get; set; }
        public GeoJsonPoint()
        {
            this.Type = "Point";
        }
    }
}
