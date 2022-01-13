using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeStackingModeChange))]
    public partial interface IChangeStackingModeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IStackingMode NextValue { get; set; }

        IStackingMode PreviousValue { get; set; }
    }
}
