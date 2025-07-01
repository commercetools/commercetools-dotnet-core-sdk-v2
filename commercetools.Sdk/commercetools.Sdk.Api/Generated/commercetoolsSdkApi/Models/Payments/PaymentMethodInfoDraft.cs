using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentMethodInfoDraft : IPaymentMethodInfoDraft
    {
        public string PaymentInterface { get; set; }

        public string Method { get; set; }

        public ILocalizedString Name { get; set; }

        public IPaymentMethodToken Token { get; set; }

        public string InterfaceAccount { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
