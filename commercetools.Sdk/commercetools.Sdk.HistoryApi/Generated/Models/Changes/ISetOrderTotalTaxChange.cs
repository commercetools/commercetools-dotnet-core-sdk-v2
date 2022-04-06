using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTotalTaxChange))]
    public partial interface ISetOrderTotalTaxChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITaxMode TaxMode { get; set; }

        IMoney NextValue { get; set; }

        IMoney PreviousValue { get; set; }
    }
}
