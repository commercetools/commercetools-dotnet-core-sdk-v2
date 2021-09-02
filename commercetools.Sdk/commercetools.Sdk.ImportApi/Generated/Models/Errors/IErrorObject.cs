using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [TypeDiscriminator(nameof(Code))]
    [DefaultTypeDiscriminator(typeof(commercetools.ImportApi.Models.Errors.ErrorObject))]
    [SubTypeDiscriminator("access_denied", typeof(commercetools.ImportApi.Models.Errors.AccessDeniedError))]
    [SubTypeDiscriminator("ConcurrentModification", typeof(commercetools.ImportApi.Models.Errors.ConcurrentModificationError))]
    [SubTypeDiscriminator("Contention", typeof(commercetools.ImportApi.Models.Errors.ContentionError))]
    [SubTypeDiscriminator("DuplicateAttributeValue", typeof(commercetools.ImportApi.Models.Errors.DuplicateAttributeValueError))]
    [SubTypeDiscriminator("DuplicateAttributeValues", typeof(commercetools.ImportApi.Models.Errors.DuplicateAttributeValuesError))]
    [SubTypeDiscriminator("DuplicateField", typeof(commercetools.ImportApi.Models.Errors.DuplicateFieldError))]
    [SubTypeDiscriminator("DuplicateVariantValues", typeof(commercetools.ImportApi.Models.Errors.DuplicateVariantValuesError))]
    [SubTypeDiscriminator("Generic", typeof(commercetools.ImportApi.Models.Errors.GenericError))]
    [SubTypeDiscriminator("insufficient_scope", typeof(commercetools.ImportApi.Models.Errors.InsufficientScopeError))]
    [SubTypeDiscriminator("invalid_scope", typeof(commercetools.ImportApi.Models.Errors.InvalidScopeError))]
    [SubTypeDiscriminator("invalid_token", typeof(commercetools.ImportApi.Models.Errors.InvalidTokenError))]
    [SubTypeDiscriminator("InvalidCredentials", typeof(commercetools.ImportApi.Models.Errors.InvalidCredentialsError))]
    [SubTypeDiscriminator("InvalidField", typeof(commercetools.ImportApi.Models.Errors.InvalidFieldError))]
    [SubTypeDiscriminator("InvalidInput", typeof(commercetools.ImportApi.Models.Errors.InvalidInput))]
    [SubTypeDiscriminator("InvalidJsonInput", typeof(commercetools.ImportApi.Models.Errors.InvalidJsonInput))]
    [SubTypeDiscriminator("InvalidOperation", typeof(commercetools.ImportApi.Models.Errors.InvalidOperation))]
    [SubTypeDiscriminator("InvalidTransition", typeof(commercetools.ImportApi.Models.Errors.InvalidStateTransitionError))]
    [SubTypeDiscriminator("RequiredField", typeof(commercetools.ImportApi.Models.Errors.RequiredFieldError))]
    [SubTypeDiscriminator("ResourceCreation", typeof(commercetools.ImportApi.Models.Errors.ResourceCreationError))]
    [SubTypeDiscriminator("ResourceDeletion", typeof(commercetools.ImportApi.Models.Errors.ResourceDeletionError))]
    [SubTypeDiscriminator("ResourceNotFound", typeof(commercetools.ImportApi.Models.Errors.ResourceNotFoundError))]
    [SubTypeDiscriminator("ResourceUpdate", typeof(commercetools.ImportApi.Models.Errors.ResourceUpdateError))]
    public partial interface IErrorObject
    {
        string Code { get; set; }

        string Message { get; set; }
    }
}
