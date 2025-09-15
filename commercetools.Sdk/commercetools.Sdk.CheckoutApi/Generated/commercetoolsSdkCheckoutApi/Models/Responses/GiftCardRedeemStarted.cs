

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class GiftCardRedeemStarted : IGiftCardRedeemStarted
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public GiftCardRedeemStarted()
        {
            this.Code = "gift_card_redeem_started";
        }
    }
}
