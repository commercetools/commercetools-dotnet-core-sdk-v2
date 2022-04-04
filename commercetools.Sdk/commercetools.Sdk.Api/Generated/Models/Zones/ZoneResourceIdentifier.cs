using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Zones
{
    public partial class ZoneResourceIdentifier : IZoneResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ZoneResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("zone");
        }
    }
}
