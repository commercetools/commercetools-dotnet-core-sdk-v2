using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.ImportWaitForMasterVariantEventData))]
    public partial interface IImportWaitForMasterVariantEventData
    {
        string Id { get; set; }

        int Version { get; set; }

        string ImportContainerKey { get; set; }

    }
}
