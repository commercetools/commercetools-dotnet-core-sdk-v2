using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.GeoLocation))]
    public partial interface IGeoLocation : IGeoJson
    {
        new string Type { get; set; }

        IList<int> Coordinates { get; set; }

        IEnumerable<int> CoordinatesEnumerable { set => Coordinates = value.ToList(); }

    }
}
