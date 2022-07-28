using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.GeoLocation))]
    public partial interface IGeoLocation
    {
        string Type { get; set; }

        List<int> Coordinates { get; set; }

    }
}
