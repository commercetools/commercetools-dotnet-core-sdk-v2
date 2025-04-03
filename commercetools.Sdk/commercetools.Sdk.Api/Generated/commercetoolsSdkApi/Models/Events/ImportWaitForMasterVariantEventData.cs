

namespace commercetools.Sdk.Api.Models.Events
{

    public partial class ImportWaitForMasterVariantEventData : IImportWaitForMasterVariantEventData
    {
        public string Id { get; set; }

        public int Version { get; set; }

        public string ImportContainerKey { get; set; }
    }
}
