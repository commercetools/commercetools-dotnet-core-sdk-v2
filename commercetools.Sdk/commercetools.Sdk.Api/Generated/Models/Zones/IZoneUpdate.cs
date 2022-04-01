using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneUpdate))]
    public partial interface IZoneUpdate
    {
        long Version { get; set; }

        List<IZoneUpdateAction> Actions { get; set; }
    }
}
