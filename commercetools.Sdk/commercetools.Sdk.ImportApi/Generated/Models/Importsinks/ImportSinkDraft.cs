using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Importsinks
{
    public partial class ImportSinkDraft : IImportSinkDraft
    {
        public string Key { get; set; }

        public IImportResourceType ResourceType { get; set; }
    }
}
