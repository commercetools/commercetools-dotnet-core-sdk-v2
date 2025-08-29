

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class GiftCardBalanceError : IGiftCardBalanceError
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public GiftCardBalanceError()
        {
            this.Code = "gift_card_balance_error";
        }
    }
}
