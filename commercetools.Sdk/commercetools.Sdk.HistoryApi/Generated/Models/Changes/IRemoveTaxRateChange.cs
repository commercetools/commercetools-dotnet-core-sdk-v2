using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveTaxRateChange))]
    public partial interface IRemoveTaxRateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITaxRate PreviousValue { get; set; }

        ITaxRate NextValue { get; set; }

    }
}
