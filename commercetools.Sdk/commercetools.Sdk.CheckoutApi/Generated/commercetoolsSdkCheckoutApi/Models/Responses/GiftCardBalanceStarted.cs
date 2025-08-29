

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class GiftCardBalanceStarted : IGiftCardBalanceStarted
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public GiftCardBalanceStarted()
        {
            this.Code = "gift_card_balance_started";
        }
    }
}
