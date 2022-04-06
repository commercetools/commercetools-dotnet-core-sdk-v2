using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTaxCalculationModeChange))]
    public partial interface IChangeTaxCalculationModeChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITaxCalculationMode PreviousValue { get; set; }

        ITaxCalculationMode NextValue { get; set; }
    }
}
