

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class GiftCardRedeemError : IGiftCardRedeemError
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public GiftCardRedeemError()
        {
            this.Code = "gift_card_redeem_error";
        }
    }
}
