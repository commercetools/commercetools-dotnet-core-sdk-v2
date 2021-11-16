using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Zones
{
    public partial class ZoneResourceIdentifier : IZoneResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set;}
        
        public string Id { get; set;}
        
        public string Key { get; set;}
        public ZoneResourceIdentifier()
        { 
           this.TypeId = IReferenceTypeId.FindEnum("zone");
        }
    }
}
