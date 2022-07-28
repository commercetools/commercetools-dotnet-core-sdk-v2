using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.PaymentLabel))]
    public partial interface IPaymentLabel : ILabel
    {
        new string Type { get; set; }

        string Key { get; set; }

        IMoney AmountPlanned { get; set; }

    }
}
