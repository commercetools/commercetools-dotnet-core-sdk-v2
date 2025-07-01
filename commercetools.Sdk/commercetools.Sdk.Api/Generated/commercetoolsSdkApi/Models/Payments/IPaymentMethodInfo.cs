using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.PaymentMethods;
using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentMethodInfo))]
    public partial interface IPaymentMethodInfo
    {
        string PaymentInterface { get; set; }

        string Method { get; set; }

        ILocalizedString Name { get; set; }

        IPaymentMethodToken Token { get; set; }

        string InterfaceAccount { get; set; }

        ICustomFields Custom { get; set; }

    }
}
