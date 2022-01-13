using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeTaxRoundingModeChange))]
    public partial interface IChangeTaxRoundingModeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IRoundingMode PreviousValue { get; set; }

        IRoundingMode NextValue { get; set; }
    }
}
