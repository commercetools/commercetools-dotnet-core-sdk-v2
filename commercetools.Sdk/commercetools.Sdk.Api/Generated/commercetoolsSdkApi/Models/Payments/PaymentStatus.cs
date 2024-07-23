using commercetools.Sdk.Api.Models.States;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentStatus : IPaymentStatus
    {
        public string InterfaceCode { get; set; }

        public string InterfaceText { get; set; }

        public IStateReference State { get; set; }
    }
}
