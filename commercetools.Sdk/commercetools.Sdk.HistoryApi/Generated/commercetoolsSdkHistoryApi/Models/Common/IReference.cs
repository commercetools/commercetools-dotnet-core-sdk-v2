using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.Reference))]
    public partial interface IReference
    {
        string Id { get; set; }

        IReferenceTypeId TypeId { get; set; }

    }
}
