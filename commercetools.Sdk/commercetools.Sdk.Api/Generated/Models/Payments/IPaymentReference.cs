using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentReference))]
    public partial interface IPaymentReference : IReference
    {
        IPayment Obj { get; set; }
    }
}
