using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class GeoLocation : IGeoLocation
    {
        public string Type { get; set; }

        public List<int> Coordinates { get; set; }
    }
}
