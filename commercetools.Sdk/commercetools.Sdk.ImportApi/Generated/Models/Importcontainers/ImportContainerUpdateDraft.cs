using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Importcontainers
{
    public partial class ImportContainerUpdateDraft : IImportContainerUpdateDraft
    {
        public long Version { get; set;}
        
        public IImportResourceType ResourceType { get; set;}
    }
}
