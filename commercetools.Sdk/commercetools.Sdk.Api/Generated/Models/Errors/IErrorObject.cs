using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [TypeDiscriminator(nameof(Code))]
    [SubTypeDiscriminator("ExtensionBadResponse", typeof(commercetools.Api.Models.Errors.ExtensionBadResponseError))]
    [SubTypeDiscriminator("ExtensionNoResponse", typeof(commercetools.Api.Models.Errors.ExtensionNoResponseError))]
    [SubTypeDiscriminator("ExtensionUpdateActionsFailed", typeof(commercetools.Api.Models.Errors.ExtensionUpdateActionsFailedError))]
    [SubTypeDiscriminator("ExternalOAuthFailed", typeof(commercetools.Api.Models.Errors.ExternalOAuthFailedError))]
    [SubTypeDiscriminator("FeatureRemoved", typeof(commercetools.Api.Models.Errors.FeatureRemovedError))]
    [SubTypeDiscriminator("General", typeof(commercetools.Api.Models.Errors.GeneralError))]
    [SubTypeDiscriminator("insufficient_scope", typeof(commercetools.Api.Models.Errors.InsufficientScopeError))]
    [SubTypeDiscriminator("InternalConstraintViolated", typeof(commercetools.Api.Models.Errors.InternalConstraintViolatedError))]
    [SubTypeDiscriminator("InvalidCredentials", typeof(commercetools.Api.Models.Errors.InvalidCredentialsError))]
    [SubTypeDiscriminator("InvalidCurrentPassword", typeof(commercetools.Api.Models.Errors.InvalidCurrentPasswordError))]
    [SubTypeDiscriminator("InvalidField", typeof(commercetools.Api.Models.Errors.InvalidFieldError))]
    [SubTypeDiscriminator("InvalidInput", typeof(commercetools.Api.Models.Errors.InvalidInputError))]
    [SubTypeDiscriminator("InvalidItemShippingDetails", typeof(commercetools.Api.Models.Errors.InvalidItemShippingDetailsError))]
    [SubTypeDiscriminator("InvalidJsonInput", typeof(commercetools.Api.Models.Errors.InvalidJsonInputError))]
    [SubTypeDiscriminator("InvalidOperation", typeof(commercetools.Api.Models.Errors.InvalidOperationError))]
    [SubTypeDiscriminator("InvalidSubject", typeof(commercetools.Api.Models.Errors.InvalidSubjectError))]
    [SubTypeDiscriminator("invalid_token", typeof(commercetools.Api.Models.Errors.InvalidTokenError))]
    [SubTypeDiscriminator("LanguageUsedInStores", typeof(commercetools.Api.Models.Errors.LanguageUsedInStoresError))]
    [SubTypeDiscriminator("MatchingPriceNotFound", typeof(commercetools.Api.Models.Errors.MatchingPriceNotFoundError))]
    [SubTypeDiscriminator("MaxResourceLimitExceeded", typeof(commercetools.Api.Models.Errors.MaxResourceLimitExceededError))]
    [SubTypeDiscriminator("MissingRoleOnChannel", typeof(commercetools.Api.Models.Errors.MissingRoleOnChannelError))]
    [SubTypeDiscriminator("MissingTaxRateForCountry", typeof(commercetools.Api.Models.Errors.MissingTaxRateForCountryError))]
    [SubTypeDiscriminator("NoMatchingProductDiscountFound", typeof(commercetools.Api.Models.Errors.NoMatchingProductDiscountFoundError))]
    [SubTypeDiscriminator("NotEnabled", typeof(commercetools.Api.Models.Errors.NotEnabledError))]
    [SubTypeDiscriminator("ObjectNotFound", typeof(commercetools.Api.Models.Errors.ObjectNotFoundError))]
    [SubTypeDiscriminator("OutOfStock", typeof(commercetools.Api.Models.Errors.OutOfStockError))]
    [SubTypeDiscriminator("OverCapacity", typeof(commercetools.Api.Models.Errors.OverCapacityError))]
    [SubTypeDiscriminator("PendingOperation", typeof(commercetools.Api.Models.Errors.PendingOperationError))]
    [SubTypeDiscriminator("PriceChanged", typeof(commercetools.Api.Models.Errors.PriceChangedError))]
    [SubTypeDiscriminator("ProjectNotConfiguredForLanguages", typeof(commercetools.Api.Models.Errors.ProjectNotConfiguredForLanguagesError))]
    [SubTypeDiscriminator("QueryComplexityLimitExceeded", typeof(commercetools.Api.Models.Errors.QueryComplexityLimitExceededError))]
    [SubTypeDiscriminator("QueryTimedOut", typeof(commercetools.Api.Models.Errors.QueryTimedOutError))]
    [SubTypeDiscriminator("ReferenceExists", typeof(commercetools.Api.Models.Errors.ReferenceExistsError))]
    [SubTypeDiscriminator("ReferencedResourceNotFound", typeof(commercetools.Api.Models.Errors.ReferencedResourceNotFoundError))]
    [SubTypeDiscriminator("RequiredField", typeof(commercetools.Api.Models.Errors.RequiredFieldError))]
    [SubTypeDiscriminator("ResourceNotFound", typeof(commercetools.Api.Models.Errors.ResourceNotFoundError))]
    [SubTypeDiscriminator("ResourceSizeLimitExceeded", typeof(commercetools.Api.Models.Errors.ResourceSizeLimitExceededError))]
    [SubTypeDiscriminator("SearchDeactivated", typeof(commercetools.Api.Models.Errors.SearchDeactivatedError))]
    [SubTypeDiscriminator("SearchExecutionFailure", typeof(commercetools.Api.Models.Errors.SearchExecutionFailureError))]
    [SubTypeDiscriminator("SearchFacetPathNotFound", typeof(commercetools.Api.Models.Errors.SearchFacetPathNotFoundError))]
    [SubTypeDiscriminator("SearchIndexingInProgress", typeof(commercetools.Api.Models.Errors.SearchIndexingInProgressError))]
    [SubTypeDiscriminator("SemanticError", typeof(commercetools.Api.Models.Errors.SemanticErrorError))]
    [SubTypeDiscriminator("ShippingMethodDoesNotMatchCart", typeof(commercetools.Api.Models.Errors.ShippingMethodDoesNotMatchCartError))]
    [SubTypeDiscriminator("SyntaxError", typeof(commercetools.Api.Models.Errors.SyntaxErrorError))]
    [SubTypeDiscriminator("WeakPassword", typeof(commercetools.Api.Models.Errors.WeakPasswordError))]
    [SubTypeDiscriminator("DuplicateFieldWithConflictingResource", typeof(commercetools.Api.Models.Errors.DuplicateFieldWithConflictingResourceError))]
    [SubTypeDiscriminator("DuplicateField", typeof(commercetools.Api.Models.Errors.DuplicateFieldError))]
    [SubTypeDiscriminator("DuplicateAttributeValue", typeof(commercetools.Api.Models.Errors.DuplicateAttributeValueError))]
    [SubTypeDiscriminator("DuplicateEnumValues", typeof(commercetools.Api.Models.Errors.DuplicateEnumValuesError))]
    [SubTypeDiscriminator("ConcurrentModification", typeof(commercetools.Api.Models.Errors.ConcurrentModificationError))]
    [SubTypeDiscriminator("AttributeNameDoesNotExist", typeof(commercetools.Api.Models.Errors.AttributeNameDoesNotExistError))]
    [SubTypeDiscriminator("AttributeDefinitionTypeConflict", typeof(commercetools.Api.Models.Errors.AttributeDefinitionTypeConflictError))]
    [SubTypeDiscriminator("EnumValuesMustMatch", typeof(commercetools.Api.Models.Errors.EnumValuesMustMatchError))]
    [SubTypeDiscriminator("AnonymousIdAlreadyInUse", typeof(commercetools.Api.Models.Errors.AnonymousIdAlreadyInUseError))]
    [SubTypeDiscriminator("DuplicatePriceScope", typeof(commercetools.Api.Models.Errors.DuplicatePriceScopeError))]
    [SubTypeDiscriminator("DuplicateVariantValues", typeof(commercetools.Api.Models.Errors.DuplicateVariantValuesError))]
    [SubTypeDiscriminator("EnumValueIsUsed", typeof(commercetools.Api.Models.Errors.EnumValueIsUsedError))]
    [SubTypeDiscriminator("EnumKeyDoesNotExist", typeof(commercetools.Api.Models.Errors.EnumKeyDoesNotExistError))]
    [SubTypeDiscriminator("AttributeDefinitionAlreadyExists", typeof(commercetools.Api.Models.Errors.AttributeDefinitionAlreadyExistsError))]
    [SubTypeDiscriminator("access_denied", typeof(commercetools.Api.Models.Errors.AccessDeniedError))]
    [SubTypeDiscriminator("DuplicateAttributeValues", typeof(commercetools.Api.Models.Errors.DuplicateAttributeValuesError))]
    [SubTypeDiscriminator("EnumKeyAlreadyExists", typeof(commercetools.Api.Models.Errors.EnumKeyAlreadyExistsError))]
    [SubTypeDiscriminator("DiscountCodeNonApplicable", typeof(commercetools.Api.Models.Errors.DiscountCodeNonApplicableError))]
    [SubTypeDiscriminator("EditPreviewFailed", typeof(commercetools.Api.Models.Errors.EditPreviewFailedError))]
    public partial interface IErrorObject 
    {
        string Code { get; set;}
        
        string Message { get; set;}
    }
}
