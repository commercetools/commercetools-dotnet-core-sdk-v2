using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentResourceIdentifier))]
    public partial interface IPaymentResourceIdentifier : IResourceIdentifier
    {
    }
}
