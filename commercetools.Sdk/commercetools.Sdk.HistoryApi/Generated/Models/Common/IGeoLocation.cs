using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.GeoLocation))]
    public partial interface IGeoLocation
    {
        string Type { get; set; }

        List<int> Coordinates { get; set; }
    }
}
