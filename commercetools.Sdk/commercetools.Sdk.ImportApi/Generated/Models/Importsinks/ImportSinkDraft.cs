using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Importsinks
{
    public partial class ImportSinkDraft : IImportSinkDraft
    {
        public string Key { get; set; }

        public IImportResourceType ResourceType { get; set; }
    }
}
