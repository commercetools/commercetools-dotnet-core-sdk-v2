using commercetools.Sdk.Api.Models.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Zones
{

    public partial class ZoneUpdate : IZoneUpdate
    {
        public long Version { get; set; }

        public IList<IZoneUpdateAction> Actions { get; set; }
        public IEnumerable<IZoneUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
