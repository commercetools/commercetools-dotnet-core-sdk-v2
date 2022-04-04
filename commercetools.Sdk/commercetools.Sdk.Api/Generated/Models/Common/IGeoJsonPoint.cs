using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.GeoJsonPoint))]
    public partial interface IGeoJsonPoint : IGeoJson
    {
        List<double> Coordinates { get; set; }
    }
}
