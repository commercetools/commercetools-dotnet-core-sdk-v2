using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.GeoJsonPoint))]
    public partial interface IGeoJsonPoint : IGeoJson
    {
        List<double> Coordinates { get; set; }
    }
}
