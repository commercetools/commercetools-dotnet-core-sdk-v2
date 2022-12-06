using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneUpdate))]
    public partial interface IZoneUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IZoneUpdate, IZoneUpdateAction>
    {
        new long Version { get; set; }
        new IList<IZoneUpdateAction> Actions { get; set; }
        IEnumerable<IZoneUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
