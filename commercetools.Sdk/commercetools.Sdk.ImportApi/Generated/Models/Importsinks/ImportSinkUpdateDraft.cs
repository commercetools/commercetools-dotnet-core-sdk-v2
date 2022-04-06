using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Importsinks
{
    public partial class ImportSinkUpdateDraft : IImportSinkUpdateDraft
    {
        public long Version { get; set; }

        public IImportResourceType ResourceType { get; set; }
    }
}
