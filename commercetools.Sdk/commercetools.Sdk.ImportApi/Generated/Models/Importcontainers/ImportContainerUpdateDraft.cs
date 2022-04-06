using commercetools.Sdk.ImportApi.Models.Common;


namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    public partial class ImportContainerUpdateDraft : IImportContainerUpdateDraft
    {
        public long Version { get; set; }

        public IImportResourceType ResourceType { get; set; }
    }
}
