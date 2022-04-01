using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetStatusInterfaceCodeAction))]
    public partial interface IPaymentSetStatusInterfaceCodeAction : IPaymentUpdateAction
    {
        string InterfaceCode { get; set; }
    }
}
