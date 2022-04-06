using commercetools.Sdk.ImportApi.Models.Common;
using System;


namespace commercetools.Sdk.ImportApi.Models.Importsinks
{
    public partial class ImportSink : IImportSink
    {
        public string Key { get; set; }

        public IImportResourceType ResourceType { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }
    }
}
