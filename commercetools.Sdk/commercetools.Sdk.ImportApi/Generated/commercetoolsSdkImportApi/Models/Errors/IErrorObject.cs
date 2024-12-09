using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Errors
{
    [TypeDiscriminator(nameof(Code))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.ImportApi.Models.Errors.ErrorObject))]
    [SubTypeDiscriminator("access_denied", typeof(commercetools.Sdk.ImportApi.Models.Errors.AccessDeniedError))]
    [SubTypeDiscriminator("ConcurrentModification", typeof(commercetools.Sdk.ImportApi.Models.Errors.ConcurrentModificationError))]
    [SubTypeDiscriminator("Contention", typeof(commercetools.Sdk.ImportApi.Models.Errors.ContentionError))]
    [SubTypeDiscriminator("DuplicateAttributeValue", typeof(commercetools.Sdk.ImportApi.Models.Errors.DuplicateAttributeValueError))]
    [SubTypeDiscriminator("DuplicateAttributeValues", typeof(commercetools.Sdk.ImportApi.Models.Errors.DuplicateAttributeValuesError))]
    [SubTypeDiscriminator("DuplicateField", typeof(commercetools.Sdk.ImportApi.Models.Errors.DuplicateFieldError))]
    [SubTypeDiscriminator("DuplicateVariantValues", typeof(commercetools.Sdk.ImportApi.Models.Errors.DuplicateVariantValuesError))]
    [SubTypeDiscriminator("Generic", typeof(commercetools.Sdk.ImportApi.Models.Errors.GenericError))]
    [SubTypeDiscriminator("insufficient_scope", typeof(commercetools.Sdk.ImportApi.Models.Errors.InsufficientScopeError))]
    [SubTypeDiscriminator("invalid_scope", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidScopeError))]
    [SubTypeDiscriminator("invalid_token", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidTokenError))]
    [SubTypeDiscriminator("InvalidCredentials", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidCredentialsError))]
    [SubTypeDiscriminator("InvalidField", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidFieldError))]
    [SubTypeDiscriminator("InvalidFieldUpdate", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidFieldsUpdateError))]
    [SubTypeDiscriminator("InvalidInput", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidInput))]
    [SubTypeDiscriminator("InvalidJsonInput", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidJsonInput))]
    [SubTypeDiscriminator("InvalidOperation", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidOperation))]
    [SubTypeDiscriminator("InvalidTransition", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidStateTransitionError))]
    [SubTypeDiscriminator("NewMasterVariantAdditionNotAllowed", typeof(commercetools.Sdk.ImportApi.Models.Errors.NewMasterVariantAdditionNotAllowedError))]
    [SubTypeDiscriminator("RequiredField", typeof(commercetools.Sdk.ImportApi.Models.Errors.RequiredFieldError))]
    [SubTypeDiscriminator("ResourceCreation", typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceCreationError))]
    [SubTypeDiscriminator("ResourceDeletion", typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceDeletionError))]
    [SubTypeDiscriminator("ResourceNotFound", typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceNotFoundError))]
    [SubTypeDiscriminator("ResourceUpdate", typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceUpdateError))]
    public partial interface IErrorObject
    {
        string Code { get; set; }

        string Message { get; set; }

        static commercetools.Sdk.ImportApi.Models.Errors.AccessDeniedError AccessDenied(Action<commercetools.Sdk.ImportApi.Models.Errors.AccessDeniedError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.AccessDeniedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.ConcurrentModificationError ConcurrentModification(Action<commercetools.Sdk.ImportApi.Models.Errors.ConcurrentModificationError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.ConcurrentModificationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.ContentionError Contention(Action<commercetools.Sdk.ImportApi.Models.Errors.ContentionError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.ContentionError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.DuplicateAttributeValueError DuplicateAttributeValue(Action<commercetools.Sdk.ImportApi.Models.Errors.DuplicateAttributeValueError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.DuplicateAttributeValueError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.DuplicateAttributeValuesError DuplicateAttributeValues(Action<commercetools.Sdk.ImportApi.Models.Errors.DuplicateAttributeValuesError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.DuplicateAttributeValuesError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.DuplicateFieldError DuplicateField(Action<commercetools.Sdk.ImportApi.Models.Errors.DuplicateFieldError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.DuplicateFieldError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.DuplicateVariantValuesError DuplicateVariantValues(Action<commercetools.Sdk.ImportApi.Models.Errors.DuplicateVariantValuesError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.DuplicateVariantValuesError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.GenericError Generic(Action<commercetools.Sdk.ImportApi.Models.Errors.GenericError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.GenericError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.InsufficientScopeError InsufficientScope(Action<commercetools.Sdk.ImportApi.Models.Errors.InsufficientScopeError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.InsufficientScopeError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.InvalidScopeError InvalidScope(Action<commercetools.Sdk.ImportApi.Models.Errors.InvalidScopeError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.InvalidScopeError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.InvalidTokenError InvalidToken(Action<commercetools.Sdk.ImportApi.Models.Errors.InvalidTokenError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.InvalidTokenError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.InvalidCredentialsError InvalidCredentials(Action<commercetools.Sdk.ImportApi.Models.Errors.InvalidCredentialsError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.InvalidCredentialsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.InvalidFieldError InvalidField(Action<commercetools.Sdk.ImportApi.Models.Errors.InvalidFieldError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.InvalidFieldError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.InvalidFieldsUpdateError InvalidFieldUpdate(Action<commercetools.Sdk.ImportApi.Models.Errors.InvalidFieldsUpdateError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.InvalidFieldsUpdateError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.InvalidInput InvalidInput(Action<commercetools.Sdk.ImportApi.Models.Errors.InvalidInput> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.InvalidInput();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.InvalidJsonInput InvalidJsonInput(Action<commercetools.Sdk.ImportApi.Models.Errors.InvalidJsonInput> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.InvalidJsonInput();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.InvalidOperation InvalidOperation(Action<commercetools.Sdk.ImportApi.Models.Errors.InvalidOperation> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.InvalidOperation();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.InvalidStateTransitionError InvalidTransition(Action<commercetools.Sdk.ImportApi.Models.Errors.InvalidStateTransitionError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.InvalidStateTransitionError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.NewMasterVariantAdditionNotAllowedError NewMasterVariantAdditionNotAllowed(Action<commercetools.Sdk.ImportApi.Models.Errors.NewMasterVariantAdditionNotAllowedError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.NewMasterVariantAdditionNotAllowedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.RequiredFieldError RequiredField(Action<commercetools.Sdk.ImportApi.Models.Errors.RequiredFieldError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.RequiredFieldError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.ResourceCreationError ResourceCreation(Action<commercetools.Sdk.ImportApi.Models.Errors.ResourceCreationError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.ResourceCreationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.ResourceDeletionError ResourceDeletion(Action<commercetools.Sdk.ImportApi.Models.Errors.ResourceDeletionError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.ResourceDeletionError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.ResourceNotFoundError ResourceNotFound(Action<commercetools.Sdk.ImportApi.Models.Errors.ResourceNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.ResourceNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.ImportApi.Models.Errors.ResourceUpdateError ResourceUpdate(Action<commercetools.Sdk.ImportApi.Models.Errors.ResourceUpdateError> init = null)
        {
            var t = new commercetools.Sdk.ImportApi.Models.Errors.ResourceUpdateError();
            init?.Invoke(t);
            return t;
        }
    }
}
