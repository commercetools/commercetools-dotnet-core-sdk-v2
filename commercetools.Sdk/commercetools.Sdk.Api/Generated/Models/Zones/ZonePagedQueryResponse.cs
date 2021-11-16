using System.Collections.Generic;


namespace commercetools.Api.Models.Zones
{
    public partial class ZonePagedQueryResponse : IZonePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<IZone> Results { get; set; }
    }
}
