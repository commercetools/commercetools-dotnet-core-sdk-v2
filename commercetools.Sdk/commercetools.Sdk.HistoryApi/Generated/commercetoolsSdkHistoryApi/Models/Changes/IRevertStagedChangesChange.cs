using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RevertStagedChangesChange))]
    public partial interface IRevertStagedChangesChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

    }
}
