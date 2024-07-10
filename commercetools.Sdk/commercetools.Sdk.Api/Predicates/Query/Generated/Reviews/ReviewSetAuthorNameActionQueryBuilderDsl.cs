using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewSetAuthorNameActionQueryBuilderDsl
    {
        public ReviewSetAuthorNameActionQueryBuilderDsl()
        {
        }

        public static ReviewSetAuthorNameActionQueryBuilderDsl Of()
        {
            return new ReviewSetAuthorNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewSetAuthorNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ReviewSetAuthorNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ReviewSetAuthorNameActionQueryBuilderDsl>(p, ReviewSetAuthorNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewSetAuthorNameActionQueryBuilderDsl, string> AuthorName()
        {
            return new ComparisonPredicateBuilder<ReviewSetAuthorNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("authorName")),
            p => new CombinationQueryPredicate<ReviewSetAuthorNameActionQueryBuilderDsl>(p, ReviewSetAuthorNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
