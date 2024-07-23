using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Zones
{

    public partial class ZonePagedQueryResponse : IZonePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IZone> Results { get; set; }
        public IEnumerable<IZone> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
