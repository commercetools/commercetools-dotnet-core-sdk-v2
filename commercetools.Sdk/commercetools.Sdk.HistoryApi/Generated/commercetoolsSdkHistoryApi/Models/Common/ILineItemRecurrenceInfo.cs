using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.LineItemRecurrenceInfo))]
    public partial interface ILineItemRecurrenceInfo
    {
        IRecurrencePolicyReference RecurrencePolicy { get; set; }

        IPriceSelectionMode PriceSelectionMode { get; set; }

    }
}
