using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Zones.ZoneReference))]
    public partial interface IZoneReference : IReference
    {
        IZone Obj { get; set; }

        new string Id { get; set; }

    }
}
