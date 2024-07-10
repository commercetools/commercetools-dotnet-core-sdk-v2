using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeSetCartPredicateActionQueryBuilderDsl
    {
        public DiscountCodeSetCartPredicateActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeSetCartPredicateActionQueryBuilderDsl Of()
        {
            return new DiscountCodeSetCartPredicateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeSetCartPredicateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetCartPredicateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeSetCartPredicateActionQueryBuilderDsl>(p, DiscountCodeSetCartPredicateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeSetCartPredicateActionQueryBuilderDsl, string> CartPredicate()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetCartPredicateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("cartPredicate")),
            p => new CombinationQueryPredicate<DiscountCodeSetCartPredicateActionQueryBuilderDsl>(p, DiscountCodeSetCartPredicateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
