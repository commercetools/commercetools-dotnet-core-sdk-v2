using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    public partial class ImportContainerDraft : IImportContainerDraft
    {
        public string Key { get; set; }

        public IImportResourceType ResourceType { get; set; }
    }
}
