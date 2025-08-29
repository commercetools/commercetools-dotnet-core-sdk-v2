

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class GiftCardBalanceRemoved : IGiftCardBalanceRemoved
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public GiftCardBalanceRemoved()
        {
            this.Code = "gift_card_balance_removed";
        }
    }
}
