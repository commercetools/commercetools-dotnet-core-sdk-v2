using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentStatusStateTransitionMessagePayload : IPaymentStatusStateTransitionMessagePayload
    {
        public string Type { get; set; }

        public IStateReference State { get; set; }

        public bool Force { get; set; }
        public PaymentStatusStateTransitionMessagePayload()
        {
            this.Type = "PaymentStatusStateTransition";
        }
    }
}
