using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Importcontainers
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importcontainers.ImportContainerDraft))]
    public partial interface IImportContainerDraft
    {
        string Key { get; set; }

        IImportResourceType ResourceType { get; set; }

    }
}
