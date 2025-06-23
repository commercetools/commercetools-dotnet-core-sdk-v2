using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountGroups
{

    public partial class DiscountGroupUpdateActionQueryBuilderDsl
    {
        public DiscountGroupUpdateActionQueryBuilderDsl()
        {
        }

        public static DiscountGroupUpdateActionQueryBuilderDsl Of()
        {
            return new DiscountGroupUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountGroupUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountGroupUpdateActionQueryBuilderDsl>(p, DiscountGroupUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<DiscountGroupUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetDescriptionActionQueryBuilderDsl.Of()),
                DiscountGroupUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountGroupUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetKeyActionQueryBuilderDsl.Of()),
                DiscountGroupUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountGroupUpdateActionQueryBuilderDsl> AsSetName(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetNameActionQueryBuilderDsl.Of()),
                DiscountGroupUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<DiscountGroupUpdateActionQueryBuilderDsl> AsSetSortOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetSortOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetSortOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<DiscountGroupUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.DiscountGroups.DiscountGroupSetSortOrderActionQueryBuilderDsl.Of()),
                DiscountGroupUpdateActionQueryBuilderDsl.Of);
        }
    }
}
