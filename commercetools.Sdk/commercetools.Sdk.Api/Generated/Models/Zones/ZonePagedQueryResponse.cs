using commercetools.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    public partial class ZonePagedQueryResponse : IZonePagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Offset { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public List<IZone> Results { get; set;}
    }
}
