using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneDraft))]
    public partial interface IZoneDraft
    {
        string Key { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        List<ILocation> Locations { get; set; }
    }
}
