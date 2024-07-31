using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneDraft))]
    public partial interface IZoneDraft
    {
        string Key { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        IList<ILocation> Locations { get; set; }

        IEnumerable<ILocation> LocationsEnumerable { set => Locations = value.ToList(); }

    }
}
