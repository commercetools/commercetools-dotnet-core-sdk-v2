using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Errors
{
    [TypeDiscriminator(nameof(Code))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ErrorObject))]
    [SubTypeDiscriminator("ConcurrentModification", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ConcurrentModificationError))]
    [SubTypeDiscriminator("ConnectorFailed", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ConnectorFailedError))]
    [SubTypeDiscriminator("DuplicateFieldWithConflictingResource", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.DuplicateFieldWithConflictingResourceError))]
    [SubTypeDiscriminator("General", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.GeneralError))]
    [SubTypeDiscriminator("InvalidField", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.InvalidFieldError))]
    [SubTypeDiscriminator("InvalidInput", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.InvalidInputError))]
    [SubTypeDiscriminator("InvalidJsonInput", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.InvalidJsonInputError))]
    [SubTypeDiscriminator("InvalidOperation", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.InvalidOperationError))]
    [SubTypeDiscriminator("MaxResourceLimitExceeded", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.MaxResourceLimitExceededError))]
    [SubTypeDiscriminator("MissingProjectKey", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.MissingProjectKeyError))]
    [SubTypeDiscriminator("MultipleActionsNotAllowed", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.MultipleActionsNotAllowedError))]
    [SubTypeDiscriminator("PaymentFailure", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.PaymentFailureError))]
    [SubTypeDiscriminator("ReferencedResourceNotFound", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ReferencedResourceNotFoundError))]
    [SubTypeDiscriminator("RequiredField", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.RequiredFieldError))]
    [SubTypeDiscriminator("ResourceNotFound", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ResourceNotFoundError))]
    [SubTypeDiscriminator("ServiceUnavailable", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ServiceUnavailableError))]
    [SubTypeDiscriminator("SyntaxError", typeof(commercetools.Sdk.CheckoutApi.Models.Errors.SyntaxErrorError))]
    public partial interface IErrorObject
    {
        string Code { get; set; }

        string Message { get; set; }

        static commercetools.Sdk.CheckoutApi.Models.Errors.ConcurrentModificationError ConcurrentModification(Action<commercetools.Sdk.CheckoutApi.Models.Errors.ConcurrentModificationError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.ConcurrentModificationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.ConnectorFailedError ConnectorFailed(Action<commercetools.Sdk.CheckoutApi.Models.Errors.ConnectorFailedError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.ConnectorFailedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.DuplicateFieldWithConflictingResourceError DuplicateFieldWithConflictingResource(Action<commercetools.Sdk.CheckoutApi.Models.Errors.DuplicateFieldWithConflictingResourceError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.DuplicateFieldWithConflictingResourceError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.GeneralError General(Action<commercetools.Sdk.CheckoutApi.Models.Errors.GeneralError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.GeneralError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.InvalidFieldError InvalidField(Action<commercetools.Sdk.CheckoutApi.Models.Errors.InvalidFieldError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.InvalidFieldError();
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
        static commercetools.Sdk.CheckoutApi.Models.Errors.InvalidOperationError InvalidOperation(Action<commercetools.Sdk.CheckoutApi.Models.Errors.InvalidOperationError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.InvalidOperationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.MaxResourceLimitExceededError MaxResourceLimitExceeded(Action<commercetools.Sdk.CheckoutApi.Models.Errors.MaxResourceLimitExceededError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.MaxResourceLimitExceededError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.MissingProjectKeyError MissingProjectKey(Action<commercetools.Sdk.CheckoutApi.Models.Errors.MissingProjectKeyError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.MissingProjectKeyError();
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
        static commercetools.Sdk.CheckoutApi.Models.Errors.ReferencedResourceNotFoundError ReferencedResourceNotFound(Action<commercetools.Sdk.CheckoutApi.Models.Errors.ReferencedResourceNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.ReferencedResourceNotFoundError();
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
        static commercetools.Sdk.CheckoutApi.Models.Errors.ServiceUnavailableError ServiceUnavailable(Action<commercetools.Sdk.CheckoutApi.Models.Errors.ServiceUnavailableError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.ServiceUnavailableError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.CheckoutApi.Models.Errors.SyntaxErrorError SyntaxError(Action<commercetools.Sdk.CheckoutApi.Models.Errors.SyntaxErrorError> init = null)
        {
            var t = new commercetools.Sdk.CheckoutApi.Models.Errors.SyntaxErrorError();
            init?.Invoke(t);
            return t;
        }
    }
}
