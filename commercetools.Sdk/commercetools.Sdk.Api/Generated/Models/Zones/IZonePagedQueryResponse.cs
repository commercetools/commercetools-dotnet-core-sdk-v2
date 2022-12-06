using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZonePagedQueryResponse))]
    public partial interface IZonePagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IZone> Results { get; set; }
        IEnumerable<IZone> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
