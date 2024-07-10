using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl
    {
        public DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl Of()
        {
            return new DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl>(p, DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl>(p, DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl>(p, DiscountCodeSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
