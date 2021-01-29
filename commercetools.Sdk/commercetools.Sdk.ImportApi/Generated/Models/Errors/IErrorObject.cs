using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [TypeDiscriminator(nameof(Code))]
    [SubTypeDiscriminator("access_denied", typeof(commercetools.ImportApi.Models.Errors.AccessDeniedError))]
    [SubTypeDiscriminator("invalid_scope", typeof(commercetools.ImportApi.Models.Errors.InvalidScopeError))]
    [SubTypeDiscriminator("InvalidOperation", typeof(commercetools.ImportApi.Models.Errors.InvalidOperation))]
    [SubTypeDiscriminator("DuplicateAttributeValue", typeof(commercetools.ImportApi.Models.Errors.DuplicateAttributeValueError))]
    [SubTypeDiscriminator("DuplicateAttributeValues", typeof(commercetools.ImportApi.Models.Errors.DuplicateAttributeValuesError))]
    [SubTypeDiscriminator("DuplicateField", typeof(commercetools.ImportApi.Models.Errors.DuplicateFieldError))]
    [SubTypeDiscriminator("DuplicateVariantValues", typeof(commercetools.ImportApi.Models.Errors.DuplicateVariantValuesError))]
    [SubTypeDiscriminator("insufficient_scope", typeof(commercetools.ImportApi.Models.Errors.InsufficientScopeError))]
    [SubTypeDiscriminator("InvalidCredentials", typeof(commercetools.ImportApi.Models.Errors.InvalidCredentialsError))]
    [SubTypeDiscriminator("invalid_token", typeof(commercetools.ImportApi.Models.Errors.InvalidTokenError))]
    [SubTypeDiscriminator("InvalidField", typeof(commercetools.ImportApi.Models.Errors.InvalidFieldError))]
    [SubTypeDiscriminator("InvalidJsonInput", typeof(commercetools.ImportApi.Models.Errors.InvalidJsonInput))]
    [SubTypeDiscriminator("InvalidInput", typeof(commercetools.ImportApi.Models.Errors.InvalidInput))]
    [SubTypeDiscriminator("ResourceNotFound", typeof(commercetools.ImportApi.Models.Errors.ResourceNotFoundError))]
    [SubTypeDiscriminator("ResourceCreation", typeof(commercetools.ImportApi.Models.Errors.ResourceCreationError))]
    [SubTypeDiscriminator("ResourceUpdate", typeof(commercetools.ImportApi.Models.Errors.ResourceUpdateError))]
    [SubTypeDiscriminator("ResourceDeletion", typeof(commercetools.ImportApi.Models.Errors.ResourceDeletionError))]
    [SubTypeDiscriminator("RequiredField", typeof(commercetools.ImportApi.Models.Errors.RequiredFieldError))]
    [SubTypeDiscriminator("InvalidTransition", typeof(commercetools.ImportApi.Models.Errors.InvalidStateTransitionError))]
    [SubTypeDiscriminator("ConcurrentModification", typeof(commercetools.ImportApi.Models.Errors.ConcurrentModificationError))]
    [SubTypeDiscriminator("Contention", typeof(commercetools.ImportApi.Models.Errors.ContentionError))]
    [SubTypeDiscriminator("Generic", typeof(commercetools.ImportApi.Models.Errors.GenericError))]
    public partial interface IErrorObject 
    {
        string Code { get; set;}
        
        string Message { get; set;}
    }
}
