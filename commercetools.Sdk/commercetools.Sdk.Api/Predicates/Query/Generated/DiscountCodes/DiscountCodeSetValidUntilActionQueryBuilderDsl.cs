using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeSetValidUntilActionQueryBuilderDsl
    {
        public DiscountCodeSetValidUntilActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeSetValidUntilActionQueryBuilderDsl Of()
        {
            return new DiscountCodeSetValidUntilActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeSetValidUntilActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetValidUntilActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeSetValidUntilActionQueryBuilderDsl>(p, DiscountCodeSetValidUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeSetValidUntilActionQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetValidUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<DiscountCodeSetValidUntilActionQueryBuilderDsl>(p, DiscountCodeSetValidUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
