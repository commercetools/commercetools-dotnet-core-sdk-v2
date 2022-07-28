using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneUpdate))]
    public partial interface IZoneUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IZoneUpdate, IZoneUpdateAction>
    {
        new long Version { get; set; }
        new List<IZoneUpdateAction> Actions { get; set; }

    }
}
