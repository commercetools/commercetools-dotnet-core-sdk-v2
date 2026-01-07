using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Responses
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ExpressPaymentCompleted))]
    public partial interface IExpressPaymentCompleted : IResponseMessage
    {
        new string Code { get; set; }

        new string Severity { get; set; }

        new string Message { get; set; }

        Object Payload { get; set; }

        new string CorrelationId { get; set; }

    }
}
