using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewUpdateQueryBuilderDsl
    {
        public ReviewUpdateQueryBuilderDsl()
        {
        }

        public static ReviewUpdateQueryBuilderDsl Of()
        {
            return new ReviewUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ReviewUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ReviewUpdateQueryBuilderDsl>(p, ReviewUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReviewUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewUpdateActionQueryBuilderDsl.Of())),
                ReviewUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ReviewUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ReviewUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ReviewUpdateQueryBuilderDsl>(p, ReviewUpdateQueryBuilderDsl.Of));
        }

    }
}
