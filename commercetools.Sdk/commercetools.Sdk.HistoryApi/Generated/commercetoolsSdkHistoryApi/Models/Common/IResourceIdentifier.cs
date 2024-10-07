using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ResourceIdentifier))]
    public partial interface IResourceIdentifier
    {
        string Id { get; set; }

        string Key { get; set; }

        IReferenceTypeId TypeId { get; set; }

    }
}
