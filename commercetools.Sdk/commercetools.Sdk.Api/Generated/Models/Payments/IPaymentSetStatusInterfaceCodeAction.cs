using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetStatusInterfaceCodeAction))]
    public partial interface IPaymentSetStatusInterfaceCodeAction : IPaymentUpdateAction
    {
        string InterfaceCode { get; set;}
    }
}
