using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewSetKeyActionQueryBuilderDsl
    {
        public ReviewSetKeyActionQueryBuilderDsl()
        {
        }

        public static ReviewSetKeyActionQueryBuilderDsl Of()
        {
            return new ReviewSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ReviewSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ReviewSetKeyActionQueryBuilderDsl>(p, ReviewSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ReviewSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ReviewSetKeyActionQueryBuilderDsl>(p, ReviewSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
