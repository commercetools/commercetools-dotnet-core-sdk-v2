using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Common
{

    public partial class GeoJsonPoint : IGeoJsonPoint
    {
        public string Type { get; set; }

        public IList<decimal> Coordinates { get; set; }
        public IEnumerable<decimal> CoordinatesEnumerable { set => Coordinates = value.ToList(); }

        public GeoJsonPoint()
        {
            this.Type = "Point";
        }
    }
}
