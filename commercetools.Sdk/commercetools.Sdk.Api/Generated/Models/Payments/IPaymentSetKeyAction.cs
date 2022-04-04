using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetKeyAction))]
    public partial interface IPaymentSetKeyAction : IPaymentUpdateAction
    {
        string Key { get; set; }
    }
}
