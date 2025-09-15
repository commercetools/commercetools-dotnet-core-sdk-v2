using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Errors
{
    [TypeDiscriminator(nameof(Code))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ErrorObject))]
    [SubTypeDiscriminator("ConnectorFailed", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ConnectorFailedError))]
    [SubTypeDiscriminator("General", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.GeneralError))]
    [SubTypeDiscriminator("InvalidInput", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.InvalidInputError))]
    [SubTypeDiscriminator("InvalidJsonInput", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.InvalidJsonInputError))]
    [SubTypeDiscriminator("MultipleActionsNotAllowed", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.MultipleActionsNotAllowedError))]
    [SubTypeDiscriminator("PaymentFailure", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.PaymentFailureError))]
    [SubTypeDiscriminator("RequiredField", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.RequiredFieldError))]
    [SubTypeDiscriminator("ResourceNotFound", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ResourceNotFoundError))]
    public partial interface IErrorObject
    {
        string Code { get; set; }

        string Message { get; set; }

        static commercetools.Sdk.CheckoutApi.Models.Errors.ConnectorFailedError ConnectorFailed(Action<commercetools.Sdk.CheckoutApi.Models.Errors.ConnectorFailedError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.ConnectorFailedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.GeneralError General(Action<commercetools.Sdk.CheckoutApi.Models.Errors.GeneralError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.GeneralError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.InvalidInputError InvalidInput(Action<commercetools.Sdk.CheckoutApi.Models.Errors.InvalidInputError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.InvalidInputError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.InvalidJsonInputError InvalidJsonInput(Action<commercetools.Sdk.CheckoutApi.Models.Errors.InvalidJsonInputError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.InvalidJsonInputError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.MultipleActionsNotAllowedError MultipleActionsNotAllowed(Action<commercetools.Sdk.CheckoutApi.Models.Errors.MultipleActionsNotAllowedError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.MultipleActionsNotAllowedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.PaymentFailureError PaymentFailure(Action<commercetools.Sdk.CheckoutApi.Models.Errors.PaymentFailureError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.PaymentFailureError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.RequiredFieldError RequiredField(Action<commercetools.Sdk.CheckoutApi.Models.Errors.RequiredFieldError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.RequiredFieldError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.ResourceNotFoundError ResourceNotFound(Action<commercetools.Sdk.CheckoutApi.Models.Errors.ResourceNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.ResourceNotFoundError();
            init?.Invoke(t);
            return t;
        }
    }
}
