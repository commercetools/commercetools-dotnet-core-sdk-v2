using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetMethodInfoInterfaceAction))]
    public partial interface IPaymentSetMethodInfoInterfaceAction : IPaymentUpdateAction
    {
        string Interface { get; set; }
    }
}
