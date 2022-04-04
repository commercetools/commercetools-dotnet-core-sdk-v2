using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentResourceIdentifier))]
    public partial interface IPaymentResourceIdentifier : IResourceIdentifier
    {
    }
}
