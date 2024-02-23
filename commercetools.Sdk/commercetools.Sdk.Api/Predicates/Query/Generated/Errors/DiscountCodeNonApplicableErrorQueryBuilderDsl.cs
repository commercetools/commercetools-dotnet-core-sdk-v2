using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class DiscountCodeNonApplicableErrorQueryBuilderDsl
    {
        public DiscountCodeNonApplicableErrorQueryBuilderDsl()
        {
        }

        public static DiscountCodeNonApplicableErrorQueryBuilderDsl Of()
        {
            return new DiscountCodeNonApplicableErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<DiscountCodeNonApplicableErrorQueryBuilderDsl>(p, DiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<DiscountCodeNonApplicableErrorQueryBuilderDsl>(p, DiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, string> DiscountCode()
        {
            return new ComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountCode")),
            p => new CombinationQueryPredicate<DiscountCodeNonApplicableErrorQueryBuilderDsl>(p, DiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, string> Reason()
        {
            return new ComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reason")),
            p => new CombinationQueryPredicate<DiscountCodeNonApplicableErrorQueryBuilderDsl>(p, DiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, string> DiscountCodeId()
        {
            return new ComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountCodeId")),
            p => new CombinationQueryPredicate<DiscountCodeNonApplicableErrorQueryBuilderDsl>(p, DiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<DiscountCodeNonApplicableErrorQueryBuilderDsl>(p, DiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<DiscountCodeNonApplicableErrorQueryBuilderDsl>(p, DiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime> ValidityCheckTime()
        {
            return new ComparisonPredicateBuilder<DiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validityCheckTime")),
            p => new CombinationQueryPredicate<DiscountCodeNonApplicableErrorQueryBuilderDsl>(p, DiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
