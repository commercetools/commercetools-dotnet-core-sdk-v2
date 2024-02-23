using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentStatusDraft : IPaymentStatusDraft
    {
        public string InterfaceCode { get; set; }

        public string InterfaceText { get; set; }

        public IStateResourceIdentifier State { get; set; }
    }
}
