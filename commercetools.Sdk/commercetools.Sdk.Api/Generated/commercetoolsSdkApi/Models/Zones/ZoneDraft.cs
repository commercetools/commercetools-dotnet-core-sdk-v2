using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Zones
{

    public partial class ZoneDraft : IZoneDraft
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList<ILocation> Locations { get; set; }

        public IEnumerable<ILocation> LocationsEnumerable { set => Locations = value.ToList(); }
    }
}
