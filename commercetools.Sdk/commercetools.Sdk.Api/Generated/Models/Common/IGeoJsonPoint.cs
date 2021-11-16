using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.GeoJsonPoint))]
    public partial interface IGeoJsonPoint : IGeoJson
    {
        List<double> Coordinates { get; set;}
    }
}
