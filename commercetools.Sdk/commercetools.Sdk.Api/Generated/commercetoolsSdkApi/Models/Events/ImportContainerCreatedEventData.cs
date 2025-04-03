using System;

namespace commercetools.Sdk.Api.Models.Events
{

    public partial class ImportContainerCreatedEventData : IImportContainerCreatedEventData
    {
        public string Key { get; set; }

        public int Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }
    }
}
