using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [TypeDiscriminator(nameof(Code))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Errors.ErrorObject))]
    [SubTypeDiscriminator("access_denied", typeof(commercetools.Sdk.Api.Models.Errors.AccessDeniedError))]
    [SubTypeDiscriminator("AnonymousIdAlreadyInUse", typeof(commercetools.Sdk.Api.Models.Errors.AnonymousIdAlreadyInUseError))]
    [SubTypeDiscriminator("AttributeDefinitionAlreadyExists", typeof(commercetools.Sdk.Api.Models.Errors.AttributeDefinitionAlreadyExistsError))]
    [SubTypeDiscriminator("AttributeDefinitionTypeConflict", typeof(commercetools.Sdk.Api.Models.Errors.AttributeDefinitionTypeConflictError))]
    [SubTypeDiscriminator("AttributeNameDoesNotExist", typeof(commercetools.Sdk.Api.Models.Errors.AttributeNameDoesNotExistError))]
    [SubTypeDiscriminator("BadGateway", typeof(commercetools.Sdk.Api.Models.Errors.BadGatewayError))]
    [SubTypeDiscriminator("ConcurrentModification", typeof(commercetools.Sdk.Api.Models.Errors.ConcurrentModificationError))]
    [SubTypeDiscriminator("DiscountCodeNonApplicable", typeof(commercetools.Sdk.Api.Models.Errors.DiscountCodeNonApplicableError))]
    [SubTypeDiscriminator("DuplicateAttributeValue", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValueError))]
    [SubTypeDiscriminator("DuplicateAttributeValues", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValuesError))]
    [SubTypeDiscriminator("DuplicateEnumValues", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateEnumValuesError))]
    [SubTypeDiscriminator("DuplicateField", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateFieldError))]
    [SubTypeDiscriminator("DuplicateFieldWithConflictingResource", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateFieldWithConflictingResourceError))]
    [SubTypeDiscriminator("DuplicatePriceScope", typeof(commercetools.Sdk.Api.Models.Errors.DuplicatePriceScopeError))]
    [SubTypeDiscriminator("DuplicateStandalonePriceScope", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateStandalonePriceScopeError))]
    [SubTypeDiscriminator("DuplicateVariantValues", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateVariantValuesError))]
    [SubTypeDiscriminator("EditPreviewFailed", typeof(commercetools.Sdk.Api.Models.Errors.EditPreviewFailedError))]
    [SubTypeDiscriminator("EnumKeyAlreadyExists", typeof(commercetools.Sdk.Api.Models.Errors.EnumKeyAlreadyExistsError))]
    [SubTypeDiscriminator("EnumKeyDoesNotExist", typeof(commercetools.Sdk.Api.Models.Errors.EnumKeyDoesNotExistError))]
    [SubTypeDiscriminator("EnumValueIsUsed", typeof(commercetools.Sdk.Api.Models.Errors.EnumValueIsUsedError))]
    [SubTypeDiscriminator("EnumValuesMustMatch", typeof(commercetools.Sdk.Api.Models.Errors.EnumValuesMustMatchError))]
    [SubTypeDiscriminator("ExtensionBadResponse", typeof(commercetools.Sdk.Api.Models.Errors.ExtensionBadResponseError))]
    [SubTypeDiscriminator("ExtensionNoResponse", typeof(commercetools.Sdk.Api.Models.Errors.ExtensionNoResponseError))]
    [SubTypeDiscriminator("ExtensionUpdateActionsFailed", typeof(commercetools.Sdk.Api.Models.Errors.ExtensionUpdateActionsFailedError))]
    [SubTypeDiscriminator("ExternalOAuthFailed", typeof(commercetools.Sdk.Api.Models.Errors.ExternalOAuthFailedError))]
    [SubTypeDiscriminator("FeatureRemoved", typeof(commercetools.Sdk.Api.Models.Errors.FeatureRemovedError))]
    [SubTypeDiscriminator("General", typeof(commercetools.Sdk.Api.Models.Errors.GeneralError))]
    [SubTypeDiscriminator("insufficient_scope", typeof(commercetools.Sdk.Api.Models.Errors.InsufficientScopeError))]
    [SubTypeDiscriminator("InternalConstraintViolated", typeof(commercetools.Sdk.Api.Models.Errors.InternalConstraintViolatedError))]
    [SubTypeDiscriminator("invalid_token", typeof(commercetools.Sdk.Api.Models.Errors.InvalidTokenError))]
    [SubTypeDiscriminator("InvalidCredentials", typeof(commercetools.Sdk.Api.Models.Errors.InvalidCredentialsError))]
    [SubTypeDiscriminator("InvalidCurrentPassword", typeof(commercetools.Sdk.Api.Models.Errors.InvalidCurrentPasswordError))]
    [SubTypeDiscriminator("InvalidField", typeof(commercetools.Sdk.Api.Models.Errors.InvalidFieldError))]
    [SubTypeDiscriminator("InvalidInput", typeof(commercetools.Sdk.Api.Models.Errors.InvalidInputError))]
    [SubTypeDiscriminator("InvalidItemShippingDetails", typeof(commercetools.Sdk.Api.Models.Errors.InvalidItemShippingDetailsError))]
    [SubTypeDiscriminator("InvalidJsonInput", typeof(commercetools.Sdk.Api.Models.Errors.InvalidJsonInputError))]
    [SubTypeDiscriminator("InvalidOperation", typeof(commercetools.Sdk.Api.Models.Errors.InvalidOperationError))]
    [SubTypeDiscriminator("InvalidSubject", typeof(commercetools.Sdk.Api.Models.Errors.InvalidSubjectError))]
    [SubTypeDiscriminator("LanguageUsedInStores", typeof(commercetools.Sdk.Api.Models.Errors.LanguageUsedInStoresError))]
    [SubTypeDiscriminator("MatchingPriceNotFound", typeof(commercetools.Sdk.Api.Models.Errors.MatchingPriceNotFoundError))]
    [SubTypeDiscriminator("MaxResourceLimitExceeded", typeof(commercetools.Sdk.Api.Models.Errors.MaxResourceLimitExceededError))]
    [SubTypeDiscriminator("MissingRoleOnChannel", typeof(commercetools.Sdk.Api.Models.Errors.MissingRoleOnChannelError))]
    [SubTypeDiscriminator("MissingTaxRateForCountry", typeof(commercetools.Sdk.Api.Models.Errors.MissingTaxRateForCountryError))]
    [SubTypeDiscriminator("NoMatchingProductDiscountFound", typeof(commercetools.Sdk.Api.Models.Errors.NoMatchingProductDiscountFoundError))]
    [SubTypeDiscriminator("NotEnabled", typeof(commercetools.Sdk.Api.Models.Errors.NotEnabledError))]
    [SubTypeDiscriminator("ObjectNotFound", typeof(commercetools.Sdk.Api.Models.Errors.ObjectNotFoundError))]
    [SubTypeDiscriminator("OutOfStock", typeof(commercetools.Sdk.Api.Models.Errors.OutOfStockError))]
    [SubTypeDiscriminator("OverCapacity", typeof(commercetools.Sdk.Api.Models.Errors.OverCapacityError))]
    [SubTypeDiscriminator("OverlappingStandalonePriceValidity", typeof(commercetools.Sdk.Api.Models.Errors.OverlappingStandalonePriceValidityError))]
    [SubTypeDiscriminator("PendingOperation", typeof(commercetools.Sdk.Api.Models.Errors.PendingOperationError))]
    [SubTypeDiscriminator("PriceChanged", typeof(commercetools.Sdk.Api.Models.Errors.PriceChangedError))]
    [SubTypeDiscriminator("ProjectNotConfiguredForLanguages", typeof(commercetools.Sdk.Api.Models.Errors.ProjectNotConfiguredForLanguagesError))]
    [SubTypeDiscriminator("QueryComplexityLimitExceeded", typeof(commercetools.Sdk.Api.Models.Errors.QueryComplexityLimitExceededError))]
    [SubTypeDiscriminator("QueryTimedOut", typeof(commercetools.Sdk.Api.Models.Errors.QueryTimedOutError))]
    [SubTypeDiscriminator("ReferencedResourceNotFound", typeof(commercetools.Sdk.Api.Models.Errors.ReferencedResourceNotFoundError))]
    [SubTypeDiscriminator("ReferenceExists", typeof(commercetools.Sdk.Api.Models.Errors.ReferenceExistsError))]
    [SubTypeDiscriminator("RequiredField", typeof(commercetools.Sdk.Api.Models.Errors.RequiredFieldError))]
    [SubTypeDiscriminator("ResourceNotFound", typeof(commercetools.Sdk.Api.Models.Errors.ResourceNotFoundError))]
    [SubTypeDiscriminator("ResourceSizeLimitExceeded", typeof(commercetools.Sdk.Api.Models.Errors.ResourceSizeLimitExceededError))]
    [SubTypeDiscriminator("SearchDeactivated", typeof(commercetools.Sdk.Api.Models.Errors.SearchDeactivatedError))]
    [SubTypeDiscriminator("SearchExecutionFailure", typeof(commercetools.Sdk.Api.Models.Errors.SearchExecutionFailureError))]
    [SubTypeDiscriminator("SearchFacetPathNotFound", typeof(commercetools.Sdk.Api.Models.Errors.SearchFacetPathNotFoundError))]
    [SubTypeDiscriminator("SearchIndexingInProgress", typeof(commercetools.Sdk.Api.Models.Errors.SearchIndexingInProgressError))]
    [SubTypeDiscriminator("SemanticError", typeof(commercetools.Sdk.Api.Models.Errors.SemanticErrorError))]
    [SubTypeDiscriminator("ShippingMethodDoesNotMatchCart", typeof(commercetools.Sdk.Api.Models.Errors.ShippingMethodDoesNotMatchCartError))]
    [SubTypeDiscriminator("SyntaxError", typeof(commercetools.Sdk.Api.Models.Errors.SyntaxErrorError))]
    [SubTypeDiscriminator("WeakPassword", typeof(commercetools.Sdk.Api.Models.Errors.WeakPasswordError))]
    public partial interface IErrorObject
    {
        string Code { get; set; }

        string Message { get; set; }

        static commercetools.Sdk.Api.Models.Errors.AccessDeniedError AccessDenied(Action<commercetools.Sdk.Api.Models.Errors.AccessDeniedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.AccessDeniedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.AnonymousIdAlreadyInUseError AnonymousIdAlreadyInUse(Action<commercetools.Sdk.Api.Models.Errors.AnonymousIdAlreadyInUseError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.AnonymousIdAlreadyInUseError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.AttributeDefinitionAlreadyExistsError AttributeDefinitionAlreadyExists(Action<commercetools.Sdk.Api.Models.Errors.AttributeDefinitionAlreadyExistsError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.AttributeDefinitionAlreadyExistsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.AttributeDefinitionTypeConflictError AttributeDefinitionTypeConflict(Action<commercetools.Sdk.Api.Models.Errors.AttributeDefinitionTypeConflictError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.AttributeDefinitionTypeConflictError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.AttributeNameDoesNotExistError AttributeNameDoesNotExist(Action<commercetools.Sdk.Api.Models.Errors.AttributeNameDoesNotExistError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.AttributeNameDoesNotExistError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.BadGatewayError BadGateway(Action<commercetools.Sdk.Api.Models.Errors.BadGatewayError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.BadGatewayError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ConcurrentModificationError ConcurrentModification(Action<commercetools.Sdk.Api.Models.Errors.ConcurrentModificationError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ConcurrentModificationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.DiscountCodeNonApplicableError DiscountCodeNonApplicable(Action<commercetools.Sdk.Api.Models.Errors.DiscountCodeNonApplicableError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.DiscountCodeNonApplicableError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValueError DuplicateAttributeValue(Action<commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValueError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValueError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValuesError DuplicateAttributeValues(Action<commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValuesError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValuesError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.DuplicateEnumValuesError DuplicateEnumValues(Action<commercetools.Sdk.Api.Models.Errors.DuplicateEnumValuesError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.DuplicateEnumValuesError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.DuplicateFieldError DuplicateField(Action<commercetools.Sdk.Api.Models.Errors.DuplicateFieldError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.DuplicateFieldError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.DuplicateFieldWithConflictingResourceError DuplicateFieldWithConflictingResource(Action<commercetools.Sdk.Api.Models.Errors.DuplicateFieldWithConflictingResourceError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.DuplicateFieldWithConflictingResourceError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.DuplicatePriceScopeError DuplicatePriceScope(Action<commercetools.Sdk.Api.Models.Errors.DuplicatePriceScopeError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.DuplicatePriceScopeError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.DuplicateStandalonePriceScopeError DuplicateStandalonePriceScope(Action<commercetools.Sdk.Api.Models.Errors.DuplicateStandalonePriceScopeError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.DuplicateStandalonePriceScopeError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.DuplicateVariantValuesError DuplicateVariantValues(Action<commercetools.Sdk.Api.Models.Errors.DuplicateVariantValuesError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.DuplicateVariantValuesError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.EditPreviewFailedError EditPreviewFailed(Action<commercetools.Sdk.Api.Models.Errors.EditPreviewFailedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.EditPreviewFailedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.EnumKeyAlreadyExistsError EnumKeyAlreadyExists(Action<commercetools.Sdk.Api.Models.Errors.EnumKeyAlreadyExistsError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.EnumKeyAlreadyExistsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.EnumKeyDoesNotExistError EnumKeyDoesNotExist(Action<commercetools.Sdk.Api.Models.Errors.EnumKeyDoesNotExistError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.EnumKeyDoesNotExistError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.EnumValueIsUsedError EnumValueIsUsed(Action<commercetools.Sdk.Api.Models.Errors.EnumValueIsUsedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.EnumValueIsUsedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.EnumValuesMustMatchError EnumValuesMustMatch(Action<commercetools.Sdk.Api.Models.Errors.EnumValuesMustMatchError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.EnumValuesMustMatchError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExtensionBadResponseError ExtensionBadResponse(Action<commercetools.Sdk.Api.Models.Errors.ExtensionBadResponseError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExtensionBadResponseError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExtensionNoResponseError ExtensionNoResponse(Action<commercetools.Sdk.Api.Models.Errors.ExtensionNoResponseError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExtensionNoResponseError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExtensionUpdateActionsFailedError ExtensionUpdateActionsFailed(Action<commercetools.Sdk.Api.Models.Errors.ExtensionUpdateActionsFailedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExtensionUpdateActionsFailedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExternalOAuthFailedError ExternalOAuthFailed(Action<commercetools.Sdk.Api.Models.Errors.ExternalOAuthFailedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExternalOAuthFailedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.FeatureRemovedError FeatureRemoved(Action<commercetools.Sdk.Api.Models.Errors.FeatureRemovedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.FeatureRemovedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.GeneralError General(Action<commercetools.Sdk.Api.Models.Errors.GeneralError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.GeneralError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.InsufficientScopeError InsufficientScope(Action<commercetools.Sdk.Api.Models.Errors.InsufficientScopeError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.InsufficientScopeError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.InternalConstraintViolatedError InternalConstraintViolated(Action<commercetools.Sdk.Api.Models.Errors.InternalConstraintViolatedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.InternalConstraintViolatedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.InvalidTokenError InvalidToken(Action<commercetools.Sdk.Api.Models.Errors.InvalidTokenError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.InvalidTokenError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.InvalidCredentialsError InvalidCredentials(Action<commercetools.Sdk.Api.Models.Errors.InvalidCredentialsError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.InvalidCredentialsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.InvalidCurrentPasswordError InvalidCurrentPassword(Action<commercetools.Sdk.Api.Models.Errors.InvalidCurrentPasswordError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.InvalidCurrentPasswordError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.InvalidFieldError InvalidField(Action<commercetools.Sdk.Api.Models.Errors.InvalidFieldError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.InvalidFieldError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.InvalidInputError InvalidInput(Action<commercetools.Sdk.Api.Models.Errors.InvalidInputError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.InvalidInputError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.InvalidItemShippingDetailsError InvalidItemShippingDetails(Action<commercetools.Sdk.Api.Models.Errors.InvalidItemShippingDetailsError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.InvalidItemShippingDetailsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.InvalidJsonInputError InvalidJsonInput(Action<commercetools.Sdk.Api.Models.Errors.InvalidJsonInputError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.InvalidJsonInputError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.InvalidOperationError InvalidOperation(Action<commercetools.Sdk.Api.Models.Errors.InvalidOperationError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.InvalidOperationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.InvalidSubjectError InvalidSubject(Action<commercetools.Sdk.Api.Models.Errors.InvalidSubjectError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.InvalidSubjectError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.LanguageUsedInStoresError LanguageUsedInStores(Action<commercetools.Sdk.Api.Models.Errors.LanguageUsedInStoresError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.LanguageUsedInStoresError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.MatchingPriceNotFoundError MatchingPriceNotFound(Action<commercetools.Sdk.Api.Models.Errors.MatchingPriceNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.MatchingPriceNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.MaxResourceLimitExceededError MaxResourceLimitExceeded(Action<commercetools.Sdk.Api.Models.Errors.MaxResourceLimitExceededError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.MaxResourceLimitExceededError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.MissingRoleOnChannelError MissingRoleOnChannel(Action<commercetools.Sdk.Api.Models.Errors.MissingRoleOnChannelError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.MissingRoleOnChannelError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.MissingTaxRateForCountryError MissingTaxRateForCountry(Action<commercetools.Sdk.Api.Models.Errors.MissingTaxRateForCountryError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.MissingTaxRateForCountryError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.NoMatchingProductDiscountFoundError NoMatchingProductDiscountFound(Action<commercetools.Sdk.Api.Models.Errors.NoMatchingProductDiscountFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.NoMatchingProductDiscountFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.NotEnabledError NotEnabled(Action<commercetools.Sdk.Api.Models.Errors.NotEnabledError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.NotEnabledError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ObjectNotFoundError ObjectNotFound(Action<commercetools.Sdk.Api.Models.Errors.ObjectNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ObjectNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.OutOfStockError OutOfStock(Action<commercetools.Sdk.Api.Models.Errors.OutOfStockError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.OutOfStockError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.OverCapacityError OverCapacity(Action<commercetools.Sdk.Api.Models.Errors.OverCapacityError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.OverCapacityError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.OverlappingStandalonePriceValidityError OverlappingStandalonePriceValidity(Action<commercetools.Sdk.Api.Models.Errors.OverlappingStandalonePriceValidityError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.OverlappingStandalonePriceValidityError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.PendingOperationError PendingOperation(Action<commercetools.Sdk.Api.Models.Errors.PendingOperationError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.PendingOperationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.PriceChangedError PriceChanged(Action<commercetools.Sdk.Api.Models.Errors.PriceChangedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.PriceChangedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ProjectNotConfiguredForLanguagesError ProjectNotConfiguredForLanguages(Action<commercetools.Sdk.Api.Models.Errors.ProjectNotConfiguredForLanguagesError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ProjectNotConfiguredForLanguagesError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.QueryComplexityLimitExceededError QueryComplexityLimitExceeded(Action<commercetools.Sdk.Api.Models.Errors.QueryComplexityLimitExceededError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.QueryComplexityLimitExceededError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.QueryTimedOutError QueryTimedOut(Action<commercetools.Sdk.Api.Models.Errors.QueryTimedOutError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.QueryTimedOutError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ReferencedResourceNotFoundError ReferencedResourceNotFound(Action<commercetools.Sdk.Api.Models.Errors.ReferencedResourceNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ReferencedResourceNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ReferenceExistsError ReferenceExists(Action<commercetools.Sdk.Api.Models.Errors.ReferenceExistsError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ReferenceExistsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.RequiredFieldError RequiredField(Action<commercetools.Sdk.Api.Models.Errors.RequiredFieldError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.RequiredFieldError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ResourceNotFoundError ResourceNotFound(Action<commercetools.Sdk.Api.Models.Errors.ResourceNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ResourceNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ResourceSizeLimitExceededError ResourceSizeLimitExceeded(Action<commercetools.Sdk.Api.Models.Errors.ResourceSizeLimitExceededError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ResourceSizeLimitExceededError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.SearchDeactivatedError SearchDeactivated(Action<commercetools.Sdk.Api.Models.Errors.SearchDeactivatedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.SearchDeactivatedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.SearchExecutionFailureError SearchExecutionFailure(Action<commercetools.Sdk.Api.Models.Errors.SearchExecutionFailureError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.SearchExecutionFailureError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.SearchFacetPathNotFoundError SearchFacetPathNotFound(Action<commercetools.Sdk.Api.Models.Errors.SearchFacetPathNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.SearchFacetPathNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.SearchIndexingInProgressError SearchIndexingInProgress(Action<commercetools.Sdk.Api.Models.Errors.SearchIndexingInProgressError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.SearchIndexingInProgressError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.SemanticErrorError SemanticError(Action<commercetools.Sdk.Api.Models.Errors.SemanticErrorError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.SemanticErrorError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ShippingMethodDoesNotMatchCartError ShippingMethodDoesNotMatchCart(Action<commercetools.Sdk.Api.Models.Errors.ShippingMethodDoesNotMatchCartError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ShippingMethodDoesNotMatchCartError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.SyntaxErrorError SyntaxError(Action<commercetools.Sdk.Api.Models.Errors.SyntaxErrorError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.SyntaxErrorError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.WeakPasswordError WeakPassword(Action<commercetools.Sdk.Api.Models.Errors.WeakPasswordError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.WeakPasswordError();
            init?.Invoke(t);
            return t;
        }
    }
}
