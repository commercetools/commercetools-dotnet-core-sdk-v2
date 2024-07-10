using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeChangeGroupsActionQueryBuilderDsl
    {
        public DiscountCodeChangeGroupsActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeChangeGroupsActionQueryBuilderDsl Of()
        {
            return new DiscountCodeChangeGroupsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeChangeGroupsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeChangeGroupsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeChangeGroupsActionQueryBuilderDsl>(p, DiscountCodeChangeGroupsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<DiscountCodeChangeGroupsActionQueryBuilderDsl, string> Groups()
        {
            return new ComparableCollectionPredicateBuilder<DiscountCodeChangeGroupsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("groups")),
            p => new CombinationQueryPredicate<DiscountCodeChangeGroupsActionQueryBuilderDsl>(p, DiscountCodeChangeGroupsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
