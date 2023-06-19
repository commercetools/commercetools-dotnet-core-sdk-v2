using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeUpdateActionQueryBuilderDsl
    {
        public DiscountCodeUpdateActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeUpdateActionQueryBuilderDsl Of()
        {
            return new DiscountCodeUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(p, DiscountCodeUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsChangeCartDiscounts(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeChangeCartDiscountsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeChangeCartDiscountsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeChangeCartDiscountsActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsChangeGroups(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeChangeGroupsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeChangeGroupsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeChangeGroupsActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsChangeIsActive(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeChangeIsActiveActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeChangeIsActiveActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeChangeIsActiveActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsSetCartPredicate(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetCartPredicateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetCartPredicateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetCartPredicateActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetCustomFieldActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetCustomTypeActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetDescriptionActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsSetMaxApplications(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetMaxApplicationsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetMaxApplicationsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetMaxApplicationsActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsSetMaxApplicationsPerCustomer(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetMaxApplicationsPerCustomerActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsSetName(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetNameActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsSetValidFrom(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetValidFromActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetValidFromActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetValidFromActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsSetValidFromAndUntil(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl> AsSetValidUntil(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetValidUntilActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetValidUntilActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountCodeUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountCodes.DiscountCodeSetValidUntilActionQueryBuilderDsl.Of()),
                DiscountCodeUpdateActionQueryBuilderDsl.Of);
        }
    }
}
