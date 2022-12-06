using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.GeoLocation))]
    public partial interface IGeoLocation
    {
        string Type { get; set; }

        IList<int> Coordinates { get; set; }
        IEnumerable<int> CoordinatesEnumerable { set => Coordinates = value.ToList(); }


    }
}
