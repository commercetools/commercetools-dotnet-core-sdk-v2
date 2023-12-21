using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLErrorObjectQueryBuilderDsl
    {
        public GraphQLErrorObjectQueryBuilderDsl()
        {
        }

        public static GraphQLErrorObjectQueryBuilderDsl Of()
        {
            return new GraphQLErrorObjectQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLErrorObjectQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLErrorObjectQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(p, GraphQLErrorObjectQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsAnonymousIdAlreadyInUse(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAnonymousIdAlreadyInUseErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAnonymousIdAlreadyInUseErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAnonymousIdAlreadyInUseErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsAssociateMissingPermission(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAssociateMissingPermissionErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAssociateMissingPermissionErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAssociateMissingPermissionErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsAttributeDefinitionAlreadyExists(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAttributeDefinitionAlreadyExistsErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsAttributeDefinitionTypeConflict(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAttributeDefinitionTypeConflictErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsAttributeNameDoesNotExist(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLAttributeNameDoesNotExistErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsBadGateway(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLBadGatewayErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLBadGatewayErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLBadGatewayErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsConcurrentModification(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLConcurrentModificationErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLConcurrentModificationErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLConcurrentModificationErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsContentTooLarge(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLContentTooLargeErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLContentTooLargeErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLContentTooLargeErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsCountryNotConfiguredInStore(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLCountryNotConfiguredInStoreErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsDiscountCodeNonApplicable(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsDuplicateAttributeValue(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateAttributeValueErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateAttributeValueErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateAttributeValueErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsDuplicateAttributeValues(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateAttributeValuesErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsDuplicateEnumValues(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateEnumValuesErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateEnumValuesErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateEnumValuesErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsDuplicateField(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateFieldErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateFieldErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateFieldErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsDuplicateFieldWithConflictingResource(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateFieldWithConflictingResourceErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsDuplicatePriceKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicatePriceKeyErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicatePriceKeyErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicatePriceKeyErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsDuplicatePriceScope(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicatePriceScopeErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicatePriceScopeErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicatePriceScopeErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsDuplicateStandalonePriceScope(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateStandalonePriceScopeErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsDuplicateVariantValues(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateVariantValuesErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateVariantValuesErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLDuplicateVariantValuesErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsEditPreviewFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEditPreviewFailedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEditPreviewFailedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEditPreviewFailedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsEnumKeyAlreadyExists(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumKeyAlreadyExistsErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsEnumKeyDoesNotExist(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumKeyDoesNotExistErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsEnumValueIsUsed(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumValueIsUsedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumValueIsUsedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumValueIsUsedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsEnumValuesMustMatch(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumValuesMustMatchErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumValuesMustMatchErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLEnumValuesMustMatchErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsExtensionBadResponse(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionBadResponseErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionBadResponseErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionBadResponseErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsExtensionNoResponse(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionNoResponseErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionNoResponseErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionNoResponseErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsExtensionPredicateEvaluationFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionPredicateEvaluationFailedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsExtensionUpdateActionsFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExtensionUpdateActionsFailedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsExternalOAuthFailed(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExternalOAuthFailedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExternalOAuthFailedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLExternalOAuthFailedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsFeatureRemoved(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLFeatureRemovedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLFeatureRemovedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLFeatureRemovedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsGeneral(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLGeneralErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLGeneralErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLGeneralErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsInsufficientScope(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInsufficientScopeErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInsufficientScopeErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInsufficientScopeErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsInternalConstraintViolated(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInternalConstraintViolatedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInternalConstraintViolatedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInternalConstraintViolatedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsInvalidCredentials(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidCredentialsErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidCredentialsErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidCredentialsErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsInvalidCurrentPassword(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidCurrentPasswordErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidCurrentPasswordErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidCurrentPasswordErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsInvalidField(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidFieldErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidFieldErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidFieldErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsInvalidInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidInputErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidInputErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidInputErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsInvalidItemShippingDetails(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidItemShippingDetailsErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsInvalidJsonInput(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidJsonInputErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidJsonInputErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidJsonInputErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsInvalidOperation(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidOperationErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidOperationErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidOperationErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsInvalidSubject(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidSubjectErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidSubjectErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidSubjectErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsInvalidToken(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidTokenErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidTokenErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLInvalidTokenErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsLanguageUsedInStores(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLLanguageUsedInStoresErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLLanguageUsedInStoresErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLLanguageUsedInStoresErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsMatchingPriceNotFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMatchingPriceNotFoundErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsMaxCartDiscountsReached(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMaxCartDiscountsReachedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMaxCartDiscountsReachedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMaxCartDiscountsReachedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsMaxResourceLimitExceeded(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMaxResourceLimitExceededErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsMaxStoreReferencesReached(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMaxStoreReferencesReachedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMaxStoreReferencesReachedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMaxStoreReferencesReachedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsMissingRoleOnChannel(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMissingRoleOnChannelErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMissingRoleOnChannelErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMissingRoleOnChannelErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsMissingTaxRateForCountry(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMissingTaxRateForCountryErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsMoneyOverflow(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMoneyOverflowErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMoneyOverflowErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLMoneyOverflowErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsNoMatchingProductDiscountFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLNoMatchingProductDiscountFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLNoMatchingProductDiscountFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLNoMatchingProductDiscountFoundErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsObjectNotFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLObjectNotFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLObjectNotFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLObjectNotFoundErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsOutOfStock(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLOutOfStockErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLOutOfStockErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLOutOfStockErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsOverCapacity(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLOverCapacityErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLOverCapacityErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLOverCapacityErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsOverlappingStandalonePriceValidity(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLOverlappingStandalonePriceValidityErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsPendingOperation(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLPendingOperationErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLPendingOperationErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLPendingOperationErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsPriceChanged(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLPriceChangedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLPriceChangedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLPriceChangedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsProductAssignmentMissing(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLProductAssignmentMissingErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLProductAssignmentMissingErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLProductAssignmentMissingErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsProductPresentWithDifferentVariantSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLProductPresentWithDifferentVariantSelectionErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsProjectNotConfiguredForLanguages(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLProjectNotConfiguredForLanguagesErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsQueryComplexityLimitExceeded(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLQueryComplexityLimitExceededErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLQueryComplexityLimitExceededErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLQueryComplexityLimitExceededErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsQueryTimedOut(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLQueryTimedOutErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLQueryTimedOutErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLQueryTimedOutErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsReferenceExists(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLReferenceExistsErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLReferenceExistsErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLReferenceExistsErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsReferencedResourceNotFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLReferencedResourceNotFoundErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsRequiredField(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLRequiredFieldErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLRequiredFieldErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLRequiredFieldErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsResourceNotFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLResourceNotFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLResourceNotFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLResourceNotFoundErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsResourceSizeLimitExceeded(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLResourceSizeLimitExceededErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLResourceSizeLimitExceededErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLResourceSizeLimitExceededErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsSearchDeactivated(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchDeactivatedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchDeactivatedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchDeactivatedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsSearchExecutionFailure(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchExecutionFailureErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchExecutionFailureErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchExecutionFailureErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsSearchFacetPathNotFound(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchFacetPathNotFoundErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchFacetPathNotFoundErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchFacetPathNotFoundErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsSearchIndexingInProgress(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchIndexingInProgressErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchIndexingInProgressErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSearchIndexingInProgressErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsSemanticError(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSemanticErrorErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSemanticErrorErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSemanticErrorErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsShippingMethodDoesNotMatchCart(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLShippingMethodDoesNotMatchCartErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLShippingMethodDoesNotMatchCartErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLShippingMethodDoesNotMatchCartErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsStoreCartDiscountsLimitReached(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLStoreCartDiscountsLimitReachedErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl> AsSyntaxError(
            Func<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSyntaxErrorErrorQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSyntaxErrorErrorQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<GraphQLErrorObjectQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Errors.GraphQLSyntaxErrorErrorQueryBuilderDsl.Of()),
                GraphQLErrorObjectQueryBuilderDsl.Of);
        }
    }
}
