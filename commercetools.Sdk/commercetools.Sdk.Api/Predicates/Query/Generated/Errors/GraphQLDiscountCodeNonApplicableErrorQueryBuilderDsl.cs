using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl
    {
        public GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl()
        {
        }

        public static GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl Of()
        {
            return new GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl>(p, GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, string> DiscountCode()
        {
            return new ComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountCode")),
            p => new CombinationQueryPredicate<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl>(p, GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, string> Reason()
        {
            return new ComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reason")),
            p => new CombinationQueryPredicate<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl>(p, GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, string> DiscountCodeId()
        {
            return new ComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("discountCodeId")),
            p => new CombinationQueryPredicate<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl>(p, GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl>(p, GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl>(p, GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime> ValidityCheckTime()
        {
            return new ComparisonPredicateBuilder<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validityCheckTime")),
            p => new CombinationQueryPredicate<GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl>(p, GraphQLDiscountCodeNonApplicableErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
