

namespace commercetools.Sdk.Api.Models.Events
{

    public partial class ImportValidationFailedEventData : IImportValidationFailedEventData
    {
        public string Id { get; set; }

        public int Version { get; set; }

        public string ImportContainerKey { get; set; }
    }
}
