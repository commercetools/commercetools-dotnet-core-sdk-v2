using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxAmountChange))]
    public partial interface ISetCustomLineItemTaxAmountChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocalizedString CustomLineItem { get; set; }

        string CustomLineItemId { get; set; }

        ITaxMode TaxMode { get; set; }

        ITaxRate NextValue { get; set; }

        ITaxRate PreviousValue { get; set; }
    }
}
