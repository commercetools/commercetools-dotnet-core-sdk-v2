using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Importsinks
{
    public partial class ImportSinkUpdateDraft : IImportSinkUpdateDraft
    {
        public long Version { get; set; }

        public IImportResourceType ResourceType { get; set; }
    }
}
