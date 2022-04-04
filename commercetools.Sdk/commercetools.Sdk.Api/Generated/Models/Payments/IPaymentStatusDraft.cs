using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentStatusDraft))]
    public partial interface IPaymentStatusDraft
    {
        string InterfaceCode { get; set; }

        string InterfaceText { get; set; }

        IStateResourceIdentifier State { get; set; }
    }
}
