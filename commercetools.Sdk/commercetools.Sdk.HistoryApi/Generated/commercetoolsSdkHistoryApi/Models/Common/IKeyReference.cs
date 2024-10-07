using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.KeyReference))]
    public partial interface IKeyReference
    {
        string Key { get; set; }

        IReferenceTypeId TypeId { get; set; }

    }
}
