using commercetools.Sdk.CheckoutApi.Models.Payments;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Responses
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Responses.PaymentFailed))]
    public partial interface IPaymentFailed : IResponseMessage
    {
        new string Code { get; set; }

        new string Severity { get; set; }

        new string Message { get; set; }

        new string CorrelationId { get; set; }

        IPaymentReference Payload { get; set; }

    }
}
