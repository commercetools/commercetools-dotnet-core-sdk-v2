using commercetools.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importcontainers.ImportContainerDraft))]
    public partial interface IImportContainerDraft
    {
        string Key { get; set; }

        IImportResourceType ResourceType { get; set; }
    }
}
