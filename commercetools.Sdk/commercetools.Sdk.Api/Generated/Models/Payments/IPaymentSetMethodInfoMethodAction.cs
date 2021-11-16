using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetMethodInfoMethodAction))]
    public partial interface IPaymentSetMethodInfoMethodAction : IPaymentUpdateAction
    {
        string Method { get; set;}
    }
}
