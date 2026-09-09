using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [TypeDiscriminator(nameof(Code))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Errors.ErrorObject))]
    [SubTypeDiscriminator("AnonymousIdAlreadyInUse", typeof(commercetools.Sdk.Api.Models.Errors.AnonymousIdAlreadyInUseError))]
    [SubTypeDiscriminator("AssociateMissingPermission", typeof(commercetools.Sdk.Api.Models.Errors.AssociateMissingPermissionError))]
    [SubTypeDiscriminator("AttributeDefinitionAlreadyExists", typeof(commercetools.Sdk.Api.Models.Errors.AttributeDefinitionAlreadyExistsError))]
    [SubTypeDiscriminator("AttributeDefinitionTypeConflict", typeof(commercetools.Sdk.Api.Models.Errors.AttributeDefinitionTypeConflictError))]
    [SubTypeDiscriminator("AttributeNameDoesNotExist", typeof(commercetools.Sdk.Api.Models.Errors.AttributeNameDoesNotExistError))]
    [SubTypeDiscriminator("BadGateway", typeof(commercetools.Sdk.Api.Models.Errors.BadGatewayError))]
    [SubTypeDiscriminator("BulkOperationMaxItemsExceeded", typeof(commercetools.Sdk.Api.Models.Errors.BulkOperationMaxItemsExceededError))]
    [SubTypeDiscriminator("BusinessUnitAmbiguous", typeof(commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitAmbiguousError))]
    [SubTypeDiscriminator("BusinessUnitLimitExceeded", typeof(commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitLimitExceededError))]
    [SubTypeDiscriminator("BusinessUnitUnresolved", typeof(commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitUnresolvedError))]
    [SubTypeDiscriminator("CircularDependency", typeof(commercetools.Sdk.Api.Models.Errors.CircularDependencyError))]
    [SubTypeDiscriminator("ConcurrentModification", typeof(commercetools.Sdk.Api.Models.Errors.ConcurrentModificationError))]
    [SubTypeDiscriminator("ContentTooLarge", typeof(commercetools.Sdk.Api.Models.Errors.ContentTooLargeError))]
    [SubTypeDiscriminator("CountryNotConfiguredInStore", typeof(commercetools.Sdk.Api.Models.Errors.CountryNotConfiguredInStoreError))]
    [SubTypeDiscriminator("DiscountCodeNonApplicable", typeof(commercetools.Sdk.Api.Models.Errors.DiscountCodeNonApplicableError))]
    [SubTypeDiscriminator("DuplicateAttributeValue", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValueError))]
    [SubTypeDiscriminator("DuplicateAttributeValues", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateAttributeValuesError))]
    [SubTypeDiscriminator("DuplicateEnumValues", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateEnumValuesError))]
    [SubTypeDiscriminator("DuplicateField", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateFieldError))]
    [SubTypeDiscriminator("DuplicateFieldWithConflictingResource", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateFieldWithConflictingResourceError))]
    [SubTypeDiscriminator("DuplicatePriceKey", typeof(commercetools.Sdk.Api.Models.Errors.DuplicatePriceKeyError))]
    [SubTypeDiscriminator("DuplicatePriceScope", typeof(commercetools.Sdk.Api.Models.Errors.DuplicatePriceScopeError))]
    [SubTypeDiscriminator("DuplicateStandalonePriceScope", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateStandalonePriceScopeError))]
    [SubTypeDiscriminator("DuplicateVariantValues", typeof(commercetools.Sdk.Api.Models.Errors.DuplicateVariantValuesError))]
    [SubTypeDiscriminator("EditPreviewFailed", typeof(commercetools.Sdk.Api.Models.Errors.EditPreviewFailedError))]
    [SubTypeDiscriminator("EnumKeyAlreadyExists", typeof(commercetools.Sdk.Api.Models.Errors.EnumKeyAlreadyExistsError))]
    [SubTypeDiscriminator("EnumKeyDoesNotExist", typeof(commercetools.Sdk.Api.Models.Errors.EnumKeyDoesNotExistError))]
    [SubTypeDiscriminator("EnumValueIsUsed", typeof(commercetools.Sdk.Api.Models.Errors.EnumValueIsUsedError))]
    [SubTypeDiscriminator("EnumValuesMustMatch", typeof(commercetools.Sdk.Api.Models.Errors.EnumValuesMustMatchError))]
    [SubTypeDiscriminator("ExactLockConflict", typeof(commercetools.Sdk.Api.Models.Errors.ExactLockConflictError))]
    [SubTypeDiscriminator("ExpiredCustomerEmailToken", typeof(commercetools.Sdk.Api.Models.Errors.ExpiredCustomerEmailTokenError))]
    [SubTypeDiscriminator("ExpiredCustomerPasswordToken", typeof(commercetools.Sdk.Api.Models.Errors.ExpiredCustomerPasswordTokenError))]
    [SubTypeDiscriminator("ExtensionBadResponse", typeof(commercetools.Sdk.Api.Models.Errors.ExtensionBadResponseError))]
    [SubTypeDiscriminator("ExtensionChainTooDeep", typeof(commercetools.Sdk.Api.Models.Errors.ExtensionChainTooDeepError))]
    [SubTypeDiscriminator("ExtensionChainTooWide", typeof(commercetools.Sdk.Api.Models.Errors.ExtensionChainTooWideError))]
    [SubTypeDiscriminator("ExtensionDependencyExists", typeof(commercetools.Sdk.Api.Models.Errors.ExtensionDependencyExistsError))]
    [SubTypeDiscriminator("ExtensionNoResponse", typeof(commercetools.Sdk.Api.Models.Errors.ExtensionNoResponseError))]
    [SubTypeDiscriminator("ExtensionPredicateEvaluationFailed", typeof(commercetools.Sdk.Api.Models.Errors.ExtensionPredicateEvaluationFailedError))]
    [SubTypeDiscriminator("ExtensionUpdateActionsFailed", typeof(commercetools.Sdk.Api.Models.Errors.ExtensionUpdateActionsFailedError))]
    [SubTypeDiscriminator("ExternalOAuthFailed", typeof(commercetools.Sdk.Api.Models.Errors.ExternalOAuthFailedError))]
    [SubTypeDiscriminator("ExtractionFailed", typeof(commercetools.Sdk.Api.Models.Agents.AgentExtractionFailedError))]
    [SubTypeDiscriminator("FeatureDisabled", typeof(commercetools.Sdk.Api.Models.Agents.AgentFeatureDisabledError))]
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
    [SubTypeDiscriminator("LineItemQuantityAboveLimit", typeof(commercetools.Sdk.Api.Models.Errors.LineItemQuantityAboveLimitError))]
    [SubTypeDiscriminator("LineItemQuantityBelowLimit", typeof(commercetools.Sdk.Api.Models.Errors.LineItemQuantityBelowLimitError))]
    [SubTypeDiscriminator("LockedField", typeof(commercetools.Sdk.Api.Models.Errors.LockedFieldError))]
    [SubTypeDiscriminator("MatchingPriceNotFound", typeof(commercetools.Sdk.Api.Models.Errors.MatchingPriceNotFoundError))]
    [SubTypeDiscriminator("MaxCartDiscountsReached", typeof(commercetools.Sdk.Api.Models.Errors.MaxCartDiscountsReachedError))]
    [SubTypeDiscriminator("MaxDiscountGroupsReached", typeof(commercetools.Sdk.Api.Models.Errors.MaxDiscountGroupsReachedError))]
    [SubTypeDiscriminator("MaxResourceLimitExceeded", typeof(commercetools.Sdk.Api.Models.Errors.MaxResourceLimitExceededError))]
    [SubTypeDiscriminator("MaxStoreReferencesReached", typeof(commercetools.Sdk.Api.Models.Errors.MaxStoreReferencesReachedError))]
    [SubTypeDiscriminator("MissingCountry", typeof(commercetools.Sdk.Api.Models.Agents.AgentMissingCountryError))]
    [SubTypeDiscriminator("MissingCustomerEmail", typeof(commercetools.Sdk.Api.Models.Agents.AgentMissingCustomerEmailError))]
    [SubTypeDiscriminator("MissingDependency", typeof(commercetools.Sdk.Api.Models.Errors.MissingDependencyError))]
    [SubTypeDiscriminator("MissingEntityType", typeof(commercetools.Sdk.Api.Models.Agents.AgentMissingEntityTypeError))]
    [SubTypeDiscriminator("MissingRoleOnChannel", typeof(commercetools.Sdk.Api.Models.Errors.MissingRoleOnChannelError))]
    [SubTypeDiscriminator("MissingTaxRateForCountry", typeof(commercetools.Sdk.Api.Models.Errors.MissingTaxRateForCountryError))]
    [SubTypeDiscriminator("MoneyOverflow", typeof(commercetools.Sdk.Api.Models.Errors.MoneyOverflowError))]
    [SubTypeDiscriminator("NoLineItemsExtracted", typeof(commercetools.Sdk.Api.Models.Agents.AgentNoLineItemsExtractedError))]
    [SubTypeDiscriminator("NoMatchingProductDiscountFound", typeof(commercetools.Sdk.Api.Models.Errors.NoMatchingProductDiscountFoundError))]
    [SubTypeDiscriminator("ObjectNotFound", typeof(commercetools.Sdk.Api.Models.Errors.ObjectNotFoundError))]
    [SubTypeDiscriminator("OutOfScope", typeof(commercetools.Sdk.Api.Models.Agents.AgentOutOfScopeError))]
    [SubTypeDiscriminator("OutOfStock", typeof(commercetools.Sdk.Api.Models.Errors.OutOfStockError))]
    [SubTypeDiscriminator("OverCapacity", typeof(commercetools.Sdk.Api.Models.Errors.OverCapacityError))]
    [SubTypeDiscriminator("OverlappingPriceValidity", typeof(commercetools.Sdk.Api.Models.Errors.OverlappingPriceValidityError))]
    [SubTypeDiscriminator("OverlappingStandalonePriceValidity", typeof(commercetools.Sdk.Api.Models.Errors.OverlappingStandalonePriceValidityError))]
    [SubTypeDiscriminator("PendingOperation", typeof(commercetools.Sdk.Api.Models.Errors.PendingOperationError))]
    [SubTypeDiscriminator("PriceChanged", typeof(commercetools.Sdk.Api.Models.Errors.PriceChangedError))]
    [SubTypeDiscriminator("ProductAssignmentMissing", typeof(commercetools.Sdk.Api.Models.Errors.ProductAssignmentMissingError))]
    [SubTypeDiscriminator("ProductPresentWithDifferentVariantSelection", typeof(commercetools.Sdk.Api.Models.Errors.ProductPresentWithDifferentVariantSelectionError))]
    [SubTypeDiscriminator("ProductSearchNotEnabled", typeof(commercetools.Sdk.Api.Models.Agents.AgentProductSearchNotEnabledError))]
    [SubTypeDiscriminator("ProductsNotFound", typeof(commercetools.Sdk.Api.Models.Agents.AgentProductsNotFoundError))]
    [SubTypeDiscriminator("ProjectNotConfiguredForLanguages", typeof(commercetools.Sdk.Api.Models.Errors.ProjectNotConfiguredForLanguagesError))]
    [SubTypeDiscriminator("QueryComplexityLimitExceeded", typeof(commercetools.Sdk.Api.Models.Errors.QueryComplexityLimitExceededError))]
    [SubTypeDiscriminator("QueryTimedOut", typeof(commercetools.Sdk.Api.Models.Errors.QueryTimedOutError))]
    [SubTypeDiscriminator("QuoteRequestCreationFailed", typeof(commercetools.Sdk.Api.Models.Agents.AgentQuoteRequestCreationFailedError))]
    [SubTypeDiscriminator("RecurringOrderFailure", typeof(commercetools.Sdk.Api.Models.Errors.RecurringOrderFailureError))]
    [SubTypeDiscriminator("ReferencedResourceNotFound", typeof(commercetools.Sdk.Api.Models.Errors.ReferencedResourceNotFoundError))]
    [SubTypeDiscriminator("ReferenceExists", typeof(commercetools.Sdk.Api.Models.Errors.ReferenceExistsError))]
    [SubTypeDiscriminator("RequiredField", typeof(commercetools.Sdk.Api.Models.Errors.RequiredFieldError))]
    [SubTypeDiscriminator("ResourceNotFound", typeof(commercetools.Sdk.Api.Models.Errors.ResourceNotFoundError))]
    [SubTypeDiscriminator("ResourceSizeLimitExceeded", typeof(commercetools.Sdk.Api.Models.Errors.ResourceSizeLimitExceededError))]
    [SubTypeDiscriminator("SearchDeactivated", typeof(commercetools.Sdk.Api.Models.Errors.SearchDeactivatedError))]
    [SubTypeDiscriminator("SearchExecutionFailure", typeof(commercetools.Sdk.Api.Models.Errors.SearchExecutionFailureError))]
    [SubTypeDiscriminator("SearchFacetPathNotFound", typeof(commercetools.Sdk.Api.Models.Errors.SearchFacetPathNotFoundError))]
    [SubTypeDiscriminator("SearchIndexingInProgress", typeof(commercetools.Sdk.Api.Models.Errors.SearchIndexingInProgressError))]
    [SubTypeDiscriminator("SearchNotReady", typeof(commercetools.Sdk.Api.Models.Errors.SearchNotReadyError))]
    [SubTypeDiscriminator("SemanticError", typeof(commercetools.Sdk.Api.Models.Errors.SemanticErrorError))]
    [SubTypeDiscriminator("ShippingMethodDoesNotMatchCart", typeof(commercetools.Sdk.Api.Models.Errors.ShippingMethodDoesNotMatchCartError))]
    [SubTypeDiscriminator("StoreAmbiguous", typeof(commercetools.Sdk.Api.Models.Agents.AgentStoreAmbiguousError))]
    [SubTypeDiscriminator("StoreCartDiscountsLimitReached", typeof(commercetools.Sdk.Api.Models.Errors.StoreCartDiscountsLimitReachedError))]
    [SubTypeDiscriminator("StoreDistributionChannelsUnsupported", typeof(commercetools.Sdk.Api.Models.Agents.AgentStoreDistributionChannelsUnsupportedError))]
    [SubTypeDiscriminator("StoreUnresolved", typeof(commercetools.Sdk.Api.Models.Agents.AgentStoreUnresolvedError))]
    [SubTypeDiscriminator("SyntaxError", typeof(commercetools.Sdk.Api.Models.Errors.SyntaxErrorError))]
    [SubTypeDiscriminator("Unauthorized", typeof(commercetools.Sdk.Api.Models.Errors.UnauthorizedError))]
    [SubTypeDiscriminator("ValidityLockConflict", typeof(commercetools.Sdk.Api.Models.Errors.ValidityLockConflictError))]
    public partial interface IErrorObject
    {
        string Code { get; set; }

        string Message { get; set; }

        static commercetools.Sdk.Api.Models.Errors.AnonymousIdAlreadyInUseError AnonymousIdAlreadyInUse(Action<commercetools.Sdk.Api.Models.Errors.AnonymousIdAlreadyInUseError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.AnonymousIdAlreadyInUseError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.AssociateMissingPermissionError AssociateMissingPermission(Action<commercetools.Sdk.Api.Models.Errors.AssociateMissingPermissionError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.AssociateMissingPermissionError();
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
        static commercetools.Sdk.Api.Models.Errors.BulkOperationMaxItemsExceededError BulkOperationMaxItemsExceeded(Action<commercetools.Sdk.Api.Models.Errors.BulkOperationMaxItemsExceededError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.BulkOperationMaxItemsExceededError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitAmbiguousError BusinessUnitAmbiguous(Action<commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitAmbiguousError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitAmbiguousError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitLimitExceededError BusinessUnitLimitExceeded(Action<commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitLimitExceededError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitLimitExceededError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitUnresolvedError BusinessUnitUnresolved(Action<commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitUnresolvedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentBusinessUnitUnresolvedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.CircularDependencyError CircularDependency(Action<commercetools.Sdk.Api.Models.Errors.CircularDependencyError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.CircularDependencyError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ConcurrentModificationError ConcurrentModification(Action<commercetools.Sdk.Api.Models.Errors.ConcurrentModificationError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ConcurrentModificationError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ContentTooLargeError ContentTooLarge(Action<commercetools.Sdk.Api.Models.Errors.ContentTooLargeError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ContentTooLargeError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.CountryNotConfiguredInStoreError CountryNotConfiguredInStore(Action<commercetools.Sdk.Api.Models.Errors.CountryNotConfiguredInStoreError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.CountryNotConfiguredInStoreError();
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
        static commercetools.Sdk.Api.Models.Errors.DuplicatePriceKeyError DuplicatePriceKey(Action<commercetools.Sdk.Api.Models.Errors.DuplicatePriceKeyError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.DuplicatePriceKeyError();
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
        static commercetools.Sdk.Api.Models.Errors.ExactLockConflictError ExactLockConflict(Action<commercetools.Sdk.Api.Models.Errors.ExactLockConflictError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExactLockConflictError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExpiredCustomerEmailTokenError ExpiredCustomerEmailToken(Action<commercetools.Sdk.Api.Models.Errors.ExpiredCustomerEmailTokenError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExpiredCustomerEmailTokenError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExpiredCustomerPasswordTokenError ExpiredCustomerPasswordToken(Action<commercetools.Sdk.Api.Models.Errors.ExpiredCustomerPasswordTokenError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExpiredCustomerPasswordTokenError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExtensionBadResponseError ExtensionBadResponse(Action<commercetools.Sdk.Api.Models.Errors.ExtensionBadResponseError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExtensionBadResponseError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExtensionChainTooDeepError ExtensionChainTooDeep(Action<commercetools.Sdk.Api.Models.Errors.ExtensionChainTooDeepError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExtensionChainTooDeepError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExtensionChainTooWideError ExtensionChainTooWide(Action<commercetools.Sdk.Api.Models.Errors.ExtensionChainTooWideError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExtensionChainTooWideError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExtensionDependencyExistsError ExtensionDependencyExists(Action<commercetools.Sdk.Api.Models.Errors.ExtensionDependencyExistsError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExtensionDependencyExistsError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExtensionNoResponseError ExtensionNoResponse(Action<commercetools.Sdk.Api.Models.Errors.ExtensionNoResponseError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExtensionNoResponseError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ExtensionPredicateEvaluationFailedError ExtensionPredicateEvaluationFailed(Action<commercetools.Sdk.Api.Models.Errors.ExtensionPredicateEvaluationFailedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ExtensionPredicateEvaluationFailedError();
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
        static commercetools.Sdk.Api.Models.Agents.AgentExtractionFailedError ExtractionFailed(Action<commercetools.Sdk.Api.Models.Agents.AgentExtractionFailedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentExtractionFailedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentFeatureDisabledError FeatureDisabled(Action<commercetools.Sdk.Api.Models.Agents.AgentFeatureDisabledError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentFeatureDisabledError();
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
        static commercetools.Sdk.Api.Models.Errors.LineItemQuantityAboveLimitError LineItemQuantityAboveLimit(Action<commercetools.Sdk.Api.Models.Errors.LineItemQuantityAboveLimitError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.LineItemQuantityAboveLimitError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.LineItemQuantityBelowLimitError LineItemQuantityBelowLimit(Action<commercetools.Sdk.Api.Models.Errors.LineItemQuantityBelowLimitError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.LineItemQuantityBelowLimitError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.LockedFieldError LockedField(Action<commercetools.Sdk.Api.Models.Errors.LockedFieldError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.LockedFieldError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.MatchingPriceNotFoundError MatchingPriceNotFound(Action<commercetools.Sdk.Api.Models.Errors.MatchingPriceNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.MatchingPriceNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.MaxCartDiscountsReachedError MaxCartDiscountsReached(Action<commercetools.Sdk.Api.Models.Errors.MaxCartDiscountsReachedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.MaxCartDiscountsReachedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.MaxDiscountGroupsReachedError MaxDiscountGroupsReached(Action<commercetools.Sdk.Api.Models.Errors.MaxDiscountGroupsReachedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.MaxDiscountGroupsReachedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.MaxResourceLimitExceededError MaxResourceLimitExceeded(Action<commercetools.Sdk.Api.Models.Errors.MaxResourceLimitExceededError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.MaxResourceLimitExceededError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.MaxStoreReferencesReachedError MaxStoreReferencesReached(Action<commercetools.Sdk.Api.Models.Errors.MaxStoreReferencesReachedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.MaxStoreReferencesReachedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentMissingCountryError MissingCountry(Action<commercetools.Sdk.Api.Models.Agents.AgentMissingCountryError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentMissingCountryError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentMissingCustomerEmailError MissingCustomerEmail(Action<commercetools.Sdk.Api.Models.Agents.AgentMissingCustomerEmailError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentMissingCustomerEmailError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.MissingDependencyError MissingDependency(Action<commercetools.Sdk.Api.Models.Errors.MissingDependencyError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.MissingDependencyError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentMissingEntityTypeError MissingEntityType(Action<commercetools.Sdk.Api.Models.Agents.AgentMissingEntityTypeError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentMissingEntityTypeError();
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
        static commercetools.Sdk.Api.Models.Errors.MoneyOverflowError MoneyOverflow(Action<commercetools.Sdk.Api.Models.Errors.MoneyOverflowError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.MoneyOverflowError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentNoLineItemsExtractedError NoLineItemsExtracted(Action<commercetools.Sdk.Api.Models.Agents.AgentNoLineItemsExtractedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentNoLineItemsExtractedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.NoMatchingProductDiscountFoundError NoMatchingProductDiscountFound(Action<commercetools.Sdk.Api.Models.Errors.NoMatchingProductDiscountFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.NoMatchingProductDiscountFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ObjectNotFoundError ObjectNotFound(Action<commercetools.Sdk.Api.Models.Errors.ObjectNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ObjectNotFoundError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentOutOfScopeError OutOfScope(Action<commercetools.Sdk.Api.Models.Agents.AgentOutOfScopeError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentOutOfScopeError();
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
        static commercetools.Sdk.Api.Models.Errors.OverlappingPriceValidityError OverlappingPriceValidity(Action<commercetools.Sdk.Api.Models.Errors.OverlappingPriceValidityError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.OverlappingPriceValidityError();
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
        static commercetools.Sdk.Api.Models.Errors.ProductAssignmentMissingError ProductAssignmentMissing(Action<commercetools.Sdk.Api.Models.Errors.ProductAssignmentMissingError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ProductAssignmentMissingError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ProductPresentWithDifferentVariantSelectionError ProductPresentWithDifferentVariantSelection(Action<commercetools.Sdk.Api.Models.Errors.ProductPresentWithDifferentVariantSelectionError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ProductPresentWithDifferentVariantSelectionError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentProductSearchNotEnabledError ProductSearchNotEnabled(Action<commercetools.Sdk.Api.Models.Agents.AgentProductSearchNotEnabledError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentProductSearchNotEnabledError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentProductsNotFoundError ProductsNotFound(Action<commercetools.Sdk.Api.Models.Agents.AgentProductsNotFoundError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentProductsNotFoundError();
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
        static commercetools.Sdk.Api.Models.Agents.AgentQuoteRequestCreationFailedError QuoteRequestCreationFailed(Action<commercetools.Sdk.Api.Models.Agents.AgentQuoteRequestCreationFailedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentQuoteRequestCreationFailedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.RecurringOrderFailureError RecurringOrderFailure(Action<commercetools.Sdk.Api.Models.Errors.RecurringOrderFailureError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.RecurringOrderFailureError();
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
        static commercetools.Sdk.Api.Models.Errors.SearchNotReadyError SearchNotReady(Action<commercetools.Sdk.Api.Models.Errors.SearchNotReadyError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.SearchNotReadyError();
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
        static commercetools.Sdk.Api.Models.Agents.AgentStoreAmbiguousError StoreAmbiguous(Action<commercetools.Sdk.Api.Models.Agents.AgentStoreAmbiguousError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentStoreAmbiguousError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.StoreCartDiscountsLimitReachedError StoreCartDiscountsLimitReached(Action<commercetools.Sdk.Api.Models.Errors.StoreCartDiscountsLimitReachedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.StoreCartDiscountsLimitReachedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentStoreDistributionChannelsUnsupportedError StoreDistributionChannelsUnsupported(Action<commercetools.Sdk.Api.Models.Agents.AgentStoreDistributionChannelsUnsupportedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentStoreDistributionChannelsUnsupportedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Agents.AgentStoreUnresolvedError StoreUnresolved(Action<commercetools.Sdk.Api.Models.Agents.AgentStoreUnresolvedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Agents.AgentStoreUnresolvedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.SyntaxErrorError SyntaxError(Action<commercetools.Sdk.Api.Models.Errors.SyntaxErrorError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.SyntaxErrorError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.UnauthorizedError Unauthorized(Action<commercetools.Sdk.Api.Models.Errors.UnauthorizedError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.UnauthorizedError();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.Errors.ValidityLockConflictError ValidityLockConflict(Action<commercetools.Sdk.Api.Models.Errors.ValidityLockConflictError> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Errors.ValidityLockConflictError();
            init?.Invoke(t);
            return t;
        }
    }
}
