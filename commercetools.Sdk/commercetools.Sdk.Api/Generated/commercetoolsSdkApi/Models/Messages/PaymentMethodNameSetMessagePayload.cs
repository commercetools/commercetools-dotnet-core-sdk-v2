using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodNameSetMessagePayload : IPaymentMethodNameSetMessagePayload
    {
        public string Type { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString OldName { get; set; }
        public PaymentMethodNameSetMessagePayload()
        {
            this.Type = "PaymentMethodNameSet";
        }
    }
}
