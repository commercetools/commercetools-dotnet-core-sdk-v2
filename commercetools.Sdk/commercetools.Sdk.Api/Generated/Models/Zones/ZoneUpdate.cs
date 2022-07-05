using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Zones
{

    public partial class ZoneUpdate : IZoneUpdate
    {
        public long Version { get; set; }

        public List<IZoneUpdateAction> Actions { get; set; }
    }
}
