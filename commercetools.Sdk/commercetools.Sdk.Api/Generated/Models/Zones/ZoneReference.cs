using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Zones
{
    public partial class ZoneReference : IZoneReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IZone Obj { get; set; }
        public ZoneReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("zone");
        }
    }
}
