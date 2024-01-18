using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ErrorObjectQueryBuilderDsl
    {
        public ErrorObjectQueryBuilderDsl()
        {
        }

        public static ErrorObjectQueryBuilderDsl Of()
        {
            return new ErrorObjectQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ErrorObjectQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ErrorObjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(p, ErrorObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ErrorObjectQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ErrorObjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(p, ErrorObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsAnonymousIdAlreadyInUse(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.AnonymousIdAlreadyInUseErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.AnonymousIdAlreadyInUseErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.AnonymousIdAlreadyInUseErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsAssociateMissingPermission(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.AssociateMissingPermissionErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.AssociateMissingPermissionErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.AssociateMissingPermissionErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsAttributeDefinitionAlreadyExists(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.AttributeDefinitionAlreadyExistsErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsAttributeDefinitionTypeConflict(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.AttributeDefinitionTypeConflictErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.AttributeDefinitionTypeConflictErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.AttributeDefinitionTypeConflictErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsAttributeNameDoesNotExist(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.AttributeNameDoesNotExistErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.AttributeNameDoesNotExistErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.AttributeNameDoesNotExistErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsBadGateway(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.BadGatewayErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.BadGatewayErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.BadGatewayErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsConcurrentModification(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ConcurrentModificationErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ConcurrentModificationErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ConcurrentModificationErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsContentTooLarge(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ContentTooLargeErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ContentTooLargeErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ContentTooLargeErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsCountryNotConfiguredInStore(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.CountryNotConfiguredInStoreErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.CountryNotConfiguredInStoreErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.CountryNotConfiguredInStoreErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsDiscountCodeNonApplicable(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.DiscountCodeNonApplicableErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.DiscountCodeNonApplicableErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.DiscountCodeNonApplicableErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsDuplicateAttributeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateAttributeValueErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateAttributeValueErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateAttributeValueErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsDuplicateAttributeValues(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateAttributeValuesErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateAttributeValuesErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateAttributeValuesErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsDuplicateEnumValues(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateEnumValuesErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateEnumValuesErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateEnumValuesErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsDuplicateField(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateFieldErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateFieldErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateFieldErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsDuplicateFieldWithConflictingResource(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateFieldWithConflictingResourceErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsDuplicatePriceKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicatePriceKeyErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicatePriceKeyErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.DuplicatePriceKeyErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsDuplicatePriceScope(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicatePriceScopeErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicatePriceScopeErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.DuplicatePriceScopeErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsDuplicateStandalonePriceScope(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateStandalonePriceScopeErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateStandalonePriceScopeErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsDuplicateVariantValues(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateVariantValuesErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateVariantValuesErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.DuplicateVariantValuesErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsEditPreviewFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.EditPreviewFailedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.EditPreviewFailedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.EditPreviewFailedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsEnumKeyAlreadyExists(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.EnumKeyAlreadyExistsErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.EnumKeyAlreadyExistsErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.EnumKeyAlreadyExistsErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsEnumKeyDoesNotExist(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.EnumKeyDoesNotExistErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.EnumKeyDoesNotExistErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.EnumKeyDoesNotExistErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsEnumValueIsUsed(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.EnumValueIsUsedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.EnumValueIsUsedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.EnumValueIsUsedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsEnumValuesMustMatch(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.EnumValuesMustMatchErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.EnumValuesMustMatchErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.EnumValuesMustMatchErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsExtensionBadResponse(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionBadResponseErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionBadResponseErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionBadResponseErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsExtensionNoResponse(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionNoResponseErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionNoResponseErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionNoResponseErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsExtensionPredicateEvaluationFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionPredicateEvaluationFailedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsExtensionUpdateActionsFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionUpdateActionsFailedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionUpdateActionsFailedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsExternalOAuthFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ExternalOAuthFailedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ExternalOAuthFailedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ExternalOAuthFailedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsFeatureRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.FeatureRemovedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.FeatureRemovedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.FeatureRemovedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsGeneral(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GeneralErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GeneralErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GeneralErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsInsufficientScope(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.InsufficientScopeErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.InsufficientScopeErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.InsufficientScopeErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsInternalConstraintViolated(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.InternalConstraintViolatedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.InternalConstraintViolatedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.InternalConstraintViolatedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsInvalidCredentials(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidCredentialsErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidCredentialsErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.InvalidCredentialsErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsInvalidCurrentPassword(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidCurrentPasswordErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidCurrentPasswordErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.InvalidCurrentPasswordErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsInvalidField(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidFieldErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidFieldErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.InvalidFieldErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsInvalidInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidInputErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidInputErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.InvalidInputErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsInvalidItemShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidItemShippingDetailsErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidItemShippingDetailsErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.InvalidItemShippingDetailsErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsInvalidJsonInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidJsonInputErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidJsonInputErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.InvalidJsonInputErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsInvalidOperation(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidOperationErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidOperationErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.InvalidOperationErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsInvalidSubject(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidSubjectErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidSubjectErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.InvalidSubjectErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsInvalidToken(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidTokenErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.InvalidTokenErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.InvalidTokenErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsLanguageUsedInStores(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.LanguageUsedInStoresErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.LanguageUsedInStoresErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.LanguageUsedInStoresErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsMatchingPriceNotFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.MatchingPriceNotFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.MatchingPriceNotFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.MatchingPriceNotFoundErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsMaxCartDiscountsReached(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.MaxCartDiscountsReachedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.MaxCartDiscountsReachedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.MaxCartDiscountsReachedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsMaxResourceLimitExceeded(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.MaxResourceLimitExceededErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.MaxResourceLimitExceededErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.MaxResourceLimitExceededErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsMaxStoreReferencesReached(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.MaxStoreReferencesReachedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.MaxStoreReferencesReachedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.MaxStoreReferencesReachedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsMissingRoleOnChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.MissingRoleOnChannelErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.MissingRoleOnChannelErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.MissingRoleOnChannelErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsMissingTaxRateForCountry(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.MissingTaxRateForCountryErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.MissingTaxRateForCountryErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.MissingTaxRateForCountryErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsMoneyOverflow(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.MoneyOverflowErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.MoneyOverflowErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.MoneyOverflowErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsNoMatchingProductDiscountFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.NoMatchingProductDiscountFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.NoMatchingProductDiscountFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.NoMatchingProductDiscountFoundErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsNotEnabled(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.NotEnabledErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.NotEnabledErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.NotEnabledErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsObjectNotFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ObjectNotFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ObjectNotFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ObjectNotFoundErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsOutOfStock(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.OutOfStockErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.OutOfStockErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.OutOfStockErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsOverCapacity(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.OverCapacityErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.OverCapacityErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.OverCapacityErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsOverlappingStandalonePriceValidity(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.OverlappingStandalonePriceValidityErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.OverlappingStandalonePriceValidityErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.OverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsPendingOperation(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.PendingOperationErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.PendingOperationErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.PendingOperationErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsPriceChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.PriceChangedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.PriceChangedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.PriceChangedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsProductAssignmentMissing(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ProductAssignmentMissingErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ProductAssignmentMissingErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ProductAssignmentMissingErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsProductPresentWithDifferentVariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsProjectNotConfiguredForLanguages(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ProjectNotConfiguredForLanguagesErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsQueryComplexityLimitExceeded(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.QueryComplexityLimitExceededErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.QueryComplexityLimitExceededErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.QueryComplexityLimitExceededErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsQueryTimedOut(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.QueryTimedOutErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.QueryTimedOutErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.QueryTimedOutErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsReferenceExists(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ReferenceExistsErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ReferenceExistsErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ReferenceExistsErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsReferencedResourceNotFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ReferencedResourceNotFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ReferencedResourceNotFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ReferencedResourceNotFoundErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsRequiredField(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.RequiredFieldErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.RequiredFieldErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.RequiredFieldErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsResourceNotFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ResourceNotFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ResourceNotFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ResourceNotFoundErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsResourceSizeLimitExceeded(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ResourceSizeLimitExceededErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ResourceSizeLimitExceededErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ResourceSizeLimitExceededErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsSearchDeactivated(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.SearchDeactivatedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.SearchDeactivatedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.SearchDeactivatedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsSearchExecutionFailure(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.SearchExecutionFailureErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.SearchExecutionFailureErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.SearchExecutionFailureErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsSearchFacetPathNotFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.SearchFacetPathNotFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.SearchFacetPathNotFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.SearchFacetPathNotFoundErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsSearchIndexingInProgress(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.SearchIndexingInProgressErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.SearchIndexingInProgressErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.SearchIndexingInProgressErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsSemanticError(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.SemanticErrorErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.SemanticErrorErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.SemanticErrorErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsShippingMethodDoesNotMatchCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsStoreCartDiscountsLimitReached(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.StoreCartDiscountsLimitReachedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.StoreCartDiscountsLimitReachedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.StoreCartDiscountsLimitReachedErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ErrorObjectQueryBuilderDsl> AsSyntaxError(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.SyntaxErrorErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.SyntaxErrorErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.SyntaxErrorErrorQueryBuilderDsl.Of()),
                ErrorObjectQueryBuilderDsl.Of);
        }
    }
}
