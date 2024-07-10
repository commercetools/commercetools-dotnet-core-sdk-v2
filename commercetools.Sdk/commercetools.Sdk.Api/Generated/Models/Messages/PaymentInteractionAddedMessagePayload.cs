using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentInteractionAddedMessagePayload : IPaymentInteractionAddedMessagePayload
    {
        public string Type { get; set; }

        public ICustomFields Interaction { get; set; }
        public PaymentInteractionAddedMessagePayload()
        {
            this.Type = "PaymentInteractionAdded";
        }
    }
}
