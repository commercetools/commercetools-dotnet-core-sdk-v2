using commercetools.Sdk.Api.Models.PaymentMethods;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodInfoTokenSetMessagePayload : IPaymentMethodInfoTokenSetMessagePayload
    {
        public string Type { get; set; }

        public IPaymentMethodToken Token { get; set; }

        public IPaymentMethodToken OldToken { get; set; }
        public PaymentMethodInfoTokenSetMessagePayload()
        {
            this.Type = "PaymentMethodInfoTokenSet";
        }
    }
}
