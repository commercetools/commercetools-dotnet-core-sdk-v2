using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewSetTextActionQueryBuilderDsl
    {
        public ReviewSetTextActionQueryBuilderDsl()
        {
        }

        public static ReviewSetTextActionQueryBuilderDsl Of()
        {
            return new ReviewSetTextActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewSetTextActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ReviewSetTextActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ReviewSetTextActionQueryBuilderDsl>(p, ReviewSetTextActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewSetTextActionQueryBuilderDsl, string> Text()
        {
            return new ComparisonPredicateBuilder<ReviewSetTextActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("text")),
            p => new CombinationQueryPredicate<ReviewSetTextActionQueryBuilderDsl>(p, ReviewSetTextActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
