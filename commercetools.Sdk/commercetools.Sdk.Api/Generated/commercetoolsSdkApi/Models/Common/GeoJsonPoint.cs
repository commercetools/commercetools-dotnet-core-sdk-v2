using System.Collections.Generic;
using System.Linq;

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
