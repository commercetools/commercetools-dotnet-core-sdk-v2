using System.Collections.Generic;


namespace commercetools.Api.Models.Zones
{
    public partial class ZoneDraft : IZoneDraft
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<ILocation> Locations { get; set; }
    }
}
