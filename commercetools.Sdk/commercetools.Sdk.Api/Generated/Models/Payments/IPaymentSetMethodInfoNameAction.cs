using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetMethodInfoNameAction))]
    public partial interface IPaymentSetMethodInfoNameAction : IPaymentUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
