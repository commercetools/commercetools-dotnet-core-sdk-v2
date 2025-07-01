using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethodDraft : IPaymentMethodDraft
    {
        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ICustomerResourceIdentifier Customer { get; set; }

        public IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        public string Method { get; set; }

        public string PaymentInterface { get; set; }

        public string InterfaceAccount { get; set; }

        public IPaymentMethodToken Token { get; set; }

        public IPaymentMethodStatus PaymentMethodStatus { get; set; }

        public bool? Default { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
