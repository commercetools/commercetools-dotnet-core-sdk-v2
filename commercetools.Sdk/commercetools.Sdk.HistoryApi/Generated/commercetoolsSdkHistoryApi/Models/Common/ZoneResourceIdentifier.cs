

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ZoneResourceIdentifier : IZoneResourceIdentifier
    {
        public string Id { get; set; }

        public string Key { get; set; }

        public IReferenceTypeId TypeId { get; set; }
    }
}
