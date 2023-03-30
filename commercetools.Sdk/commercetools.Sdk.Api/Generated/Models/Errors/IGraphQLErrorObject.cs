using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [TypeDiscriminator(nameof(Code))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLErrorObject))]
    [SubTypeDiscriminator("AnonymousIdAlreadyInUse", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLAnonymousIdAlreadyInUseError))]
    [SubTypeDiscriminator("AttributeDefinitionAlreadyExists", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLAttributeDefinitionAlreadyExistsError))]
    [SubTypeDiscriminator("AttributeDefinitionTypeConflict", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLAttributeDefinitionTypeConflictError))]
    [SubTypeDiscriminator("AttributeNameDoesNotExist", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLAttributeNameDoesNotExistError))]
    [SubTypeDiscriminator("BadGateway", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLBadGatewayError))]
    [SubTypeDiscriminator("ConcurrentModification", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLConcurrentModificationError))]
    [SubTypeDiscriminator("CountryNotConfiguredInStore", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLCountryNotConfiguredInStoreError))]
    [SubTypeDiscriminator("DiscountCodeNonApplicable", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDiscountCodeNonApplicableError))]
    [SubTypeDiscriminator("DuplicateAttributeValue", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateAttributeValueError))]
    [SubTypeDiscriminator("DuplicateAttributeValues", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateAttributeValuesError))]
    [SubTypeDiscriminator("DuplicateEnumValues", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateEnumValuesError))]
    [SubTypeDiscriminator("DuplicateField", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateFieldError))]
    [SubTypeDiscriminator("DuplicateFieldWithConflictingResource", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateFieldWithConflictingResourceError))]
    [SubTypeDiscriminator("DuplicatePriceKey", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicatePriceKeyError))]
    [SubTypeDiscriminator("DuplicatePriceScope", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicatePriceScopeError))]
    [SubTypeDiscriminator("DuplicateStandalonePriceScope", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateStandalonePriceScopeError))]
    [SubTypeDiscriminator("DuplicateVariantValues", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateVariantValuesError))]
    [SubTypeDiscriminator("EditPreviewFailed", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLEditPreviewFailedError))]
    [SubTypeDiscriminator("EnumKeyAlreadyExists", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLEnumKeyAlreadyExistsError))]
    [SubTypeDiscriminator("EnumKeyDoesNotExist", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLEnumKeyDoesNotExistError))]
    [SubTypeDiscriminator("EnumValueIsUsed", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLEnumValueIsUsedError))]
    [SubTypeDiscriminator("EnumValuesMustMatch", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLEnumValuesMustMatchError))]
    [SubTypeDiscriminator("ExtensionBadResponse", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExtensionBadResponseError))]
    [SubTypeDiscriminator("ExtensionNoResponse", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExtensionNoResponseError))]
    [SubTypeDiscriminator("ExtensionPredicateEvaluationFailed", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExtensionPredicateEvaluationFailedError))]
    [SubTypeDiscriminator("ExtensionUpdateActionsFailed", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExtensionUpdateActionsFailedError))]
    [SubTypeDiscriminator("ExternalOAuthFailed", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExternalOAuthFailedError))]
    [SubTypeDiscriminator("FeatureRemoved", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLFeatureRemovedError))]
    [SubTypeDiscriminator("General", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLGeneralError))]
    [SubTypeDiscriminator("insufficient_scope", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInsufficientScopeError))]
    [SubTypeDiscriminator("InternalConstraintViolated", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInternalConstraintViolatedError))]
    [SubTypeDiscriminator("invalid_token", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidTokenError))]
    [SubTypeDiscriminator("InvalidCredentials", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidCredentialsError))]
    [SubTypeDiscriminator("InvalidCurrentPassword", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidCurrentPasswordError))]
    [SubTypeDiscriminator("InvalidField", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidFieldError))]
    [SubTypeDiscriminator("InvalidInput", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidInputError))]
    [SubTypeDiscriminator("InvalidItemShippingDetails", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidItemShippingDetailsError))]
    [SubTypeDiscriminator("InvalidJsonInput", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidJsonInputError))]
    [SubTypeDiscriminator("InvalidOperation", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidOperationError))]
    [SubTypeDiscriminator("InvalidSubject", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidSubjectError))]
    [SubTypeDiscriminator("LanguageUsedInStores", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLLanguageUsedInStoresError))]
    [SubTypeDiscriminator("MatchingPriceNotFound", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMatchingPriceNotFoundError))]
    [SubTypeDiscriminator("MaxResourceLimitExceeded", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMaxResourceLimitExceededError))]
    [SubTypeDiscriminator("MissingRoleOnChannel", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMissingRoleOnChannelError))]
    [SubTypeDiscriminator("MissingTaxRateForCountry", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMissingTaxRateForCountryError))]
    [SubTypeDiscriminator("NoMatchingProductDiscountFound", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLNoMatchingProductDiscountFoundError))]
    [SubTypeDiscriminator("NotEnabled", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLNotEnabledError))]
    [SubTypeDiscriminator("ObjectNotFound", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLObjectNotFoundError))]
    [SubTypeDiscriminator("OutOfStock", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLOutOfStockError))]
    [SubTypeDiscriminator("OverCapacity", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLOverCapacityError))]
    [SubTypeDiscriminator("OverlappingStandalonePriceValidity", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLOverlappingStandalonePriceValidityError))]
    [SubTypeDiscriminator("PendingOperation", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLPendingOperationError))]
    [SubTypeDiscriminator("PriceChanged", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLPriceChangedError))]
    [SubTypeDiscriminator("ProductAssignmentMissing", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLProductAssignmentMissingError))]
    [SubTypeDiscriminator("ProductPresentWithDifferentVariantSelection", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLProductPresentWithDifferentVariantSelectionError))]
    [SubTypeDiscriminator("ProjectNotConfiguredForLanguages", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLProjectNotConfiguredForLanguagesError))]
    [SubTypeDiscriminator("QueryComplexityLimitExceeded", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLQueryComplexityLimitExceededError))]
    [SubTypeDiscriminator("QueryTimedOut", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLQueryTimedOutError))]
    [SubTypeDiscriminator("ReferencedResourceNotFound", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLReferencedResourceNotFoundError))]
    [SubTypeDiscriminator("ReferenceExists", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLReferenceExistsError))]
    [SubTypeDiscriminator("RequiredField", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLRequiredFieldError))]
    [SubTypeDiscriminator("ResourceNotFound", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLResourceNotFoundError))]
    [SubTypeDiscriminator("ResourceSizeLimitExceeded", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLResourceSizeLimitExceededError))]
    [SubTypeDiscriminator("SearchDeactivated", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSearchDeactivatedError))]
    [SubTypeDiscriminator("SearchExecutionFailure", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSearchExecutionFailureError))]
    [SubTypeDiscriminator("SearchFacetPathNotFound", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSearchFacetPathNotFoundError))]
    [SubTypeDiscriminator("SearchIndexingInProgress", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSearchIndexingInProgressError))]
    [SubTypeDiscriminator("SemanticError", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSemanticErrorError))]
    [SubTypeDiscriminator("ShippingMethodDoesNotMatchCart", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLShippingMethodDoesNotMatchCartError))]
    [SubTypeDiscriminator("SyntaxError", typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSyntaxErrorError))]
    public partial interface IGraphQLErrorObject
    {
        string Code { get; set; }

        static commercetools.Sdk.Api.Models.Errors.GraphQLAnonymousIdAlreadyInUseError AnonymousIdAlreadyInUse(Action<commercetools.Sdk.Api.Models.Errors.GraphQLAnonymousIdAlreadyInUseError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLAnonymousIdAlreadyInUseError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLAttributeDefinitionAlreadyExistsError AttributeDefinitionAlreadyExists(Action<commercetools.Sdk.Api.Models.Errors.GraphQLAttributeDefinitionAlreadyExistsError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLAttributeDefinitionAlreadyExistsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLAttributeDefinitionTypeConflictError AttributeDefinitionTypeConflict(Action<commercetools.Sdk.Api.Models.Errors.GraphQLAttributeDefinitionTypeConflictError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLAttributeDefinitionTypeConflictError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLAttributeNameDoesNotExistError AttributeNameDoesNotExist(Action<commercetools.Sdk.Api.Models.Errors.GraphQLAttributeNameDoesNotExistError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLAttributeNameDoesNotExistError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLBadGatewayError BadGateway(Action<commercetools.Sdk.Api.Models.Errors.GraphQLBadGatewayError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLBadGatewayError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLConcurrentModificationError ConcurrentModification(Action<commercetools.Sdk.Api.Models.Errors.GraphQLConcurrentModificationError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLConcurrentModificationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLCountryNotConfiguredInStoreError CountryNotConfiguredInStore(Action<commercetools.Sdk.Api.Models.Errors.GraphQLCountryNotConfiguredInStoreError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLCountryNotConfiguredInStoreError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLDiscountCodeNonApplicableError DiscountCodeNonApplicable(Action<commercetools.Sdk.Api.Models.Errors.GraphQLDiscountCodeNonApplicableError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLDiscountCodeNonApplicableError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateAttributeValueError DuplicateAttributeValue(Action<commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateAttributeValueError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateAttributeValueError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateAttributeValuesError DuplicateAttributeValues(Action<commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateAttributeValuesError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateAttributeValuesError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateEnumValuesError DuplicateEnumValues(Action<commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateEnumValuesError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateEnumValuesError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateFieldError DuplicateField(Action<commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateFieldError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateFieldError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateFieldWithConflictingResourceError DuplicateFieldWithConflictingResource(Action<commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateFieldWithConflictingResourceError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateFieldWithConflictingResourceError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLDuplicatePriceKeyError DuplicatePriceKey(Action<commercetools.Sdk.Api.Models.Errors.GraphQLDuplicatePriceKeyError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLDuplicatePriceKeyError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLDuplicatePriceScopeError DuplicatePriceScope(Action<commercetools.Sdk.Api.Models.Errors.GraphQLDuplicatePriceScopeError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLDuplicatePriceScopeError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateStandalonePriceScopeError DuplicateStandalonePriceScope(Action<commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateStandalonePriceScopeError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateStandalonePriceScopeError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateVariantValuesError DuplicateVariantValues(Action<commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateVariantValuesError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateVariantValuesError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLEditPreviewFailedError EditPreviewFailed(Action<commercetools.Sdk.Api.Models.Errors.GraphQLEditPreviewFailedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLEditPreviewFailedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLEnumKeyAlreadyExistsError EnumKeyAlreadyExists(Action<commercetools.Sdk.Api.Models.Errors.GraphQLEnumKeyAlreadyExistsError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLEnumKeyAlreadyExistsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLEnumKeyDoesNotExistError EnumKeyDoesNotExist(Action<commercetools.Sdk.Api.Models.Errors.GraphQLEnumKeyDoesNotExistError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLEnumKeyDoesNotExistError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLEnumValueIsUsedError EnumValueIsUsed(Action<commercetools.Sdk.Api.Models.Errors.GraphQLEnumValueIsUsedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLEnumValueIsUsedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLEnumValuesMustMatchError EnumValuesMustMatch(Action<commercetools.Sdk.Api.Models.Errors.GraphQLEnumValuesMustMatchError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLEnumValuesMustMatchError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLExtensionBadResponseError ExtensionBadResponse(Action<commercetools.Sdk.Api.Models.Errors.GraphQLExtensionBadResponseError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLExtensionBadResponseError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLExtensionNoResponseError ExtensionNoResponse(Action<commercetools.Sdk.Api.Models.Errors.GraphQLExtensionNoResponseError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLExtensionNoResponseError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLExtensionPredicateEvaluationFailedError ExtensionPredicateEvaluationFailed(Action<commercetools.Sdk.Api.Models.Errors.GraphQLExtensionPredicateEvaluationFailedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLExtensionPredicateEvaluationFailedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLExtensionUpdateActionsFailedError ExtensionUpdateActionsFailed(Action<commercetools.Sdk.Api.Models.Errors.GraphQLExtensionUpdateActionsFailedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLExtensionUpdateActionsFailedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLExternalOAuthFailedError ExternalOAuthFailed(Action<commercetools.Sdk.Api.Models.Errors.GraphQLExternalOAuthFailedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLExternalOAuthFailedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLFeatureRemovedError FeatureRemoved(Action<commercetools.Sdk.Api.Models.Errors.GraphQLFeatureRemovedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLFeatureRemovedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLGeneralError General(Action<commercetools.Sdk.Api.Models.Errors.GraphQLGeneralError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLGeneralError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLInsufficientScopeError InsufficientScope(Action<commercetools.Sdk.Api.Models.Errors.GraphQLInsufficientScopeError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLInsufficientScopeError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLInternalConstraintViolatedError InternalConstraintViolated(Action<commercetools.Sdk.Api.Models.Errors.GraphQLInternalConstraintViolatedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLInternalConstraintViolatedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLInvalidTokenError InvalidToken(Action<commercetools.Sdk.Api.Models.Errors.GraphQLInvalidTokenError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLInvalidTokenError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLInvalidCredentialsError InvalidCredentials(Action<commercetools.Sdk.Api.Models.Errors.GraphQLInvalidCredentialsError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLInvalidCredentialsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLInvalidCurrentPasswordError InvalidCurrentPassword(Action<commercetools.Sdk.Api.Models.Errors.GraphQLInvalidCurrentPasswordError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLInvalidCurrentPasswordError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLInvalidFieldError InvalidField(Action<commercetools.Sdk.Api.Models.Errors.GraphQLInvalidFieldError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLInvalidFieldError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLInvalidInputError InvalidInput(Action<commercetools.Sdk.Api.Models.Errors.GraphQLInvalidInputError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLInvalidInputError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLInvalidItemShippingDetailsError InvalidItemShippingDetails(Action<commercetools.Sdk.Api.Models.Errors.GraphQLInvalidItemShippingDetailsError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLInvalidItemShippingDetailsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLInvalidJsonInputError InvalidJsonInput(Action<commercetools.Sdk.Api.Models.Errors.GraphQLInvalidJsonInputError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLInvalidJsonInputError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLInvalidOperationError InvalidOperation(Action<commercetools.Sdk.Api.Models.Errors.GraphQLInvalidOperationError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLInvalidOperationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLInvalidSubjectError InvalidSubject(Action<commercetools.Sdk.Api.Models.Errors.GraphQLInvalidSubjectError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLInvalidSubjectError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLLanguageUsedInStoresError LanguageUsedInStores(Action<commercetools.Sdk.Api.Models.Errors.GraphQLLanguageUsedInStoresError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLLanguageUsedInStoresError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLMatchingPriceNotFoundError MatchingPriceNotFound(Action<commercetools.Sdk.Api.Models.Errors.GraphQLMatchingPriceNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLMatchingPriceNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLMaxResourceLimitExceededError MaxResourceLimitExceeded(Action<commercetools.Sdk.Api.Models.Errors.GraphQLMaxResourceLimitExceededError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLMaxResourceLimitExceededError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLMissingRoleOnChannelError MissingRoleOnChannel(Action<commercetools.Sdk.Api.Models.Errors.GraphQLMissingRoleOnChannelError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLMissingRoleOnChannelError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLMissingTaxRateForCountryError MissingTaxRateForCountry(Action<commercetools.Sdk.Api.Models.Errors.GraphQLMissingTaxRateForCountryError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLMissingTaxRateForCountryError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLNoMatchingProductDiscountFoundError NoMatchingProductDiscountFound(Action<commercetools.Sdk.Api.Models.Errors.GraphQLNoMatchingProductDiscountFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLNoMatchingProductDiscountFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLNotEnabledError NotEnabled(Action<commercetools.Sdk.Api.Models.Errors.GraphQLNotEnabledError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLNotEnabledError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLObjectNotFoundError ObjectNotFound(Action<commercetools.Sdk.Api.Models.Errors.GraphQLObjectNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLObjectNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLOutOfStockError OutOfStock(Action<commercetools.Sdk.Api.Models.Errors.GraphQLOutOfStockError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLOutOfStockError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLOverCapacityError OverCapacity(Action<commercetools.Sdk.Api.Models.Errors.GraphQLOverCapacityError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLOverCapacityError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLOverlappingStandalonePriceValidityError OverlappingStandalonePriceValidity(Action<commercetools.Sdk.Api.Models.Errors.GraphQLOverlappingStandalonePriceValidityError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLOverlappingStandalonePriceValidityError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLPendingOperationError PendingOperation(Action<commercetools.Sdk.Api.Models.Errors.GraphQLPendingOperationError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLPendingOperationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLPriceChangedError PriceChanged(Action<commercetools.Sdk.Api.Models.Errors.GraphQLPriceChangedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLPriceChangedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLProductAssignmentMissingError ProductAssignmentMissing(Action<commercetools.Sdk.Api.Models.Errors.GraphQLProductAssignmentMissingError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLProductAssignmentMissingError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLProductPresentWithDifferentVariantSelectionError ProductPresentWithDifferentVariantSelection(Action<commercetools.Sdk.Api.Models.Errors.GraphQLProductPresentWithDifferentVariantSelectionError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLProductPresentWithDifferentVariantSelectionError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLProjectNotConfiguredForLanguagesError ProjectNotConfiguredForLanguages(Action<commercetools.Sdk.Api.Models.Errors.GraphQLProjectNotConfiguredForLanguagesError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLProjectNotConfiguredForLanguagesError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLQueryComplexityLimitExceededError QueryComplexityLimitExceeded(Action<commercetools.Sdk.Api.Models.Errors.GraphQLQueryComplexityLimitExceededError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLQueryComplexityLimitExceededError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLQueryTimedOutError QueryTimedOut(Action<commercetools.Sdk.Api.Models.Errors.GraphQLQueryTimedOutError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLQueryTimedOutError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLReferencedResourceNotFoundError ReferencedResourceNotFound(Action<commercetools.Sdk.Api.Models.Errors.GraphQLReferencedResourceNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLReferencedResourceNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLReferenceExistsError ReferenceExists(Action<commercetools.Sdk.Api.Models.Errors.GraphQLReferenceExistsError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLReferenceExistsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLRequiredFieldError RequiredField(Action<commercetools.Sdk.Api.Models.Errors.GraphQLRequiredFieldError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLRequiredFieldError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLResourceNotFoundError ResourceNotFound(Action<commercetools.Sdk.Api.Models.Errors.GraphQLResourceNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLResourceNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLResourceSizeLimitExceededError ResourceSizeLimitExceeded(Action<commercetools.Sdk.Api.Models.Errors.GraphQLResourceSizeLimitExceededError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLResourceSizeLimitExceededError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLSearchDeactivatedError SearchDeactivated(Action<commercetools.Sdk.Api.Models.Errors.GraphQLSearchDeactivatedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLSearchDeactivatedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLSearchExecutionFailureError SearchExecutionFailure(Action<commercetools.Sdk.Api.Models.Errors.GraphQLSearchExecutionFailureError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLSearchExecutionFailureError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLSearchFacetPathNotFoundError SearchFacetPathNotFound(Action<commercetools.Sdk.Api.Models.Errors.GraphQLSearchFacetPathNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLSearchFacetPathNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLSearchIndexingInProgressError SearchIndexingInProgress(Action<commercetools.Sdk.Api.Models.Errors.GraphQLSearchIndexingInProgressError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLSearchIndexingInProgressError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLSemanticErrorError SemanticError(Action<commercetools.Sdk.Api.Models.Errors.GraphQLSemanticErrorError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLSemanticErrorError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLShippingMethodDoesNotMatchCartError ShippingMethodDoesNotMatchCart(Action<commercetools.Sdk.Api.Models.Errors.GraphQLShippingMethodDoesNotMatchCartError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLShippingMethodDoesNotMatchCartError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GraphQLSyntaxErrorError SyntaxError(Action<commercetools.Sdk.Api.Models.Errors.GraphQLSyntaxErrorError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GraphQLSyntaxErrorError();
            init?.Invoke(t);
            return t;
        }
    }
}
