using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewPagedQueryResponseQueryBuilderDsl
    {
        public ReviewPagedQueryResponseQueryBuilderDsl()
        {
        }

        public static ReviewPagedQueryResponseQueryBuilderDsl Of()
        {
            return new ReviewPagedQueryResponseQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewPagedQueryResponseQueryBuilderDsl, long> Limit()
        {
            return new ComparisonPredicateBuilder<ReviewPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("limit")),
            p => new CombinationQueryPredicate<ReviewPagedQueryResponseQueryBuilderDsl>(p, ReviewPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewPagedQueryResponseQueryBuilderDsl, long> Count()
        {
            return new ComparisonPredicateBuilder<ReviewPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("count")),
            p => new CombinationQueryPredicate<ReviewPagedQueryResponseQueryBuilderDsl>(p, ReviewPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewPagedQueryResponseQueryBuilderDsl, long> Total()
        {
            return new ComparisonPredicateBuilder<ReviewPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("total")),
            p => new CombinationQueryPredicate<ReviewPagedQueryResponseQueryBuilderDsl>(p, ReviewPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewPagedQueryResponseQueryBuilderDsl, long> Offset()
        {
            return new ComparisonPredicateBuilder<ReviewPagedQueryResponseQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("offset")),
            p => new CombinationQueryPredicate<ReviewPagedQueryResponseQueryBuilderDsl>(p, ReviewPagedQueryResponseQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReviewPagedQueryResponseQueryBuilderDsl> Results(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewPagedQueryResponseQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("results"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl.Of())),
                ReviewPagedQueryResponseQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ReviewPagedQueryResponseQueryBuilderDsl> Results()
        {
            return new CollectionPredicateBuilder<ReviewPagedQueryResponseQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("results")),
                    p => new CombinationQueryPredicate<ReviewPagedQueryResponseQueryBuilderDsl>(p, ReviewPagedQueryResponseQueryBuilderDsl.Of));
        }

    }
}
