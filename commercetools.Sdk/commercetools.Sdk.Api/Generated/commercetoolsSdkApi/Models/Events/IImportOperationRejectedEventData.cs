using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Events
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Events.ImportOperationRejectedEventData))]
    public partial interface IImportOperationRejectedEventData
    {
        string Id { get; set; }

    }
}
