using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.PublishChange))]
    public partial interface IPublishChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

    }
}
