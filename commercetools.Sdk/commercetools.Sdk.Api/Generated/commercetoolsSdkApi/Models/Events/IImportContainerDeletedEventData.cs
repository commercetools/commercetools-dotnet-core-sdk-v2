using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.ImportContainerDeletedEventData))]
    public partial interface IImportContainerDeletedEventData
    {
        string Key { get; set; }

        int Version { get; set; }

    }
}
