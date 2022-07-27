using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentMethodInfo : IPaymentMethodInfo
    {
        public string PaymentInterface { get; set; }

        public string Method { get; set; }

        public ILocalizedString Name { get; set; }
    }
}
