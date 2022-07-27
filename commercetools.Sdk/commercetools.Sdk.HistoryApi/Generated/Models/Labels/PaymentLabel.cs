using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class PaymentLabel : IPaymentLabel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public IMoney AmountPlanned { get; set; }
        public PaymentLabel()
        {
            this.Type = "PaymentLabel";
        }
    }
}
