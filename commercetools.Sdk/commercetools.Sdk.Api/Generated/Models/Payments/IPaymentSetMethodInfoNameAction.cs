using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetMethodInfoNameAction))]
    public partial interface IPaymentSetMethodInfoNameAction : IPaymentUpdateAction
    {
        ILocalizedString Name { get; set;}
    }
}
