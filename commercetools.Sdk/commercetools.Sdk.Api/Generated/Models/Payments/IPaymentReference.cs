using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentReference))]
    public partial interface IPaymentReference : IReference
    {
        IPayment Obj { get; set; }
    }
}
