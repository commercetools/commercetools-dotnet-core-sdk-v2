using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.ZoneResourceIdentifier))]
    public partial interface IZoneResourceIdentifier : IResourceIdentifier
    {
    }
}
