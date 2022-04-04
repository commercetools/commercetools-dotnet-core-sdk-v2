using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetExternalIdAction))]
    public partial interface IPaymentSetExternalIdAction : IPaymentUpdateAction
    {
        string ExternalId { get; set; }
    }
}
