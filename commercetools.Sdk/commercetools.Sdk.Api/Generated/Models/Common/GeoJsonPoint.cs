using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Common
{

    public partial class GeoJsonPoint : IGeoJsonPoint
    {
        public string Type { get; set; }

        public List<decimal> Coordinates { get; set; }
        public GeoJsonPoint()
        {
            this.Type = "Point";
        }
    }
}
