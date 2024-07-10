using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class GeoLocation : IGeoLocation
    {
        public string Type { get; set; }

        public IList<int> Coordinates { get; set; }
        public IEnumerable<int> CoordinatesEnumerable { set => Coordinates = value.ToList(); }

    }
}
