using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.UnpublishChange))]
    public partial interface IUnpublishChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

    }
}
