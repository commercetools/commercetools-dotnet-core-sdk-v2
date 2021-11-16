using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentSetExternalIdAction))]
    public partial interface IPaymentSetExternalIdAction : IPaymentUpdateAction
    {
        string ExternalId { get; set;}
    }
}
