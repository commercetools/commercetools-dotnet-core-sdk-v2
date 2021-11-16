using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetStatusInterfaceTextAction))]
    public partial interface IPaymentSetStatusInterfaceTextAction : IPaymentUpdateAction
    {
        string InterfaceText { get; set;}
    }
}
