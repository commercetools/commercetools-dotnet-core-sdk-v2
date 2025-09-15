using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Responses
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ShippingMethodSelectionConfirmation))]
    public partial interface IShippingMethodSelectionConfirmation : IResponseMessage
    {
        new string Code { get; set; }

        new string Severity { get; set; }

        new string Message { get; set; }

        new string CorrelationId { get; set; }

        Object Payload { get; set; }

    }
}
