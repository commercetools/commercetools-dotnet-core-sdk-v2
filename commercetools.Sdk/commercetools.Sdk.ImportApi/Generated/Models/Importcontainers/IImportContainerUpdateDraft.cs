using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importcontainers.ImportContainerUpdateDraft))]
    public partial interface IImportContainerUpdateDraft
    {
        long Version { get; set; }

        IImportResourceType ResourceType { get; set; }
    }
}
