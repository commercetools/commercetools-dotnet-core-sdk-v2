using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RevertStagedVariantChangesChange))]
    public partial interface IRevertStagedVariantChangesChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

    }
}
