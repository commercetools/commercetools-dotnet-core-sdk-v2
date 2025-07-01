using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethodDraft))]
    public partial interface IPaymentMethodDraft
    {
        string Key { get; set; }

        ILocalizedString Name { get; set; }

        ICustomerResourceIdentifier Customer { get; set; }

        IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        string Method { get; set; }

        string PaymentInterface { get; set; }

        string InterfaceAccount { get; set; }

        IPaymentMethodToken Token { get; set; }

        IPaymentMethodStatus PaymentMethodStatus { get; set; }

        bool? Default { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
