using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeStackingModeChange))]
    public partial interface IChangeStackingModeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IStackingMode PreviousValue { get; set; }

        IStackingMode NextValue { get; set; }

    }
}
