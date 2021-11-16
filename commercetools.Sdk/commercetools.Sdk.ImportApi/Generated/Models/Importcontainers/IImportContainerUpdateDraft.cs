using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importcontainers.ImportContainerUpdateDraft))]
    public partial interface IImportContainerUpdateDraft 
    {
        long Version { get; set;}
        
        IImportResourceType ResourceType { get; set;}
    }
}
