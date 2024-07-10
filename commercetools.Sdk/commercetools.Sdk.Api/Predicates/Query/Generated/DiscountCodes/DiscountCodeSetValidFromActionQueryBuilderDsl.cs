using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeSetValidFromActionQueryBuilderDsl
    {
        public DiscountCodeSetValidFromActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeSetValidFromActionQueryBuilderDsl Of()
        {
            return new DiscountCodeSetValidFromActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeSetValidFromActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetValidFromActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeSetValidFromActionQueryBuilderDsl>(p, DiscountCodeSetValidFromActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeSetValidFromActionQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetValidFromActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<DiscountCodeSetValidFromActionQueryBuilderDsl>(p, DiscountCodeSetValidFromActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
