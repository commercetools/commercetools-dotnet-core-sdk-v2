using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentMethodInfo))]
    public partial interface IPaymentMethodInfo
    {
        string PaymentInterface { get; set; }

        string Method { get; set; }

        ILocalizedString Name { get; set; }
    }
}
