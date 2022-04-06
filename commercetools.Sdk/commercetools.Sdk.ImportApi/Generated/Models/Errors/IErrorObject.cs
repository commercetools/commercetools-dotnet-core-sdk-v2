using commercetools.Base.CustomAttributes;


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
    [SubTypeDiscriminator("InvalidInput", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidInput))]
    [SubTypeDiscriminator("InvalidJsonInput", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidJsonInput))]
    [SubTypeDiscriminator("InvalidOperation", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidOperation))]
    [SubTypeDiscriminator("InvalidTransition", typeof(commercetools.Sdk.ImportApi.Models.Errors.InvalidStateTransitionError))]
    [SubTypeDiscriminator("RequiredField", typeof(commercetools.Sdk.ImportApi.Models.Errors.RequiredFieldError))]
    [SubTypeDiscriminator("ResourceCreation", typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceCreationError))]
    [SubTypeDiscriminator("ResourceDeletion", typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceDeletionError))]
    [SubTypeDiscriminator("ResourceNotFound", typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceNotFoundError))]
    [SubTypeDiscriminator("ResourceUpdate", typeof(commercetools.Sdk.ImportApi.Models.Errors.ResourceUpdateError))]
    public partial interface IErrorObject
    {
        string Code { get; set; }

        string Message { get; set; }
    }
}
