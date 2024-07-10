using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ReviewCreatedMessagePayloadQueryBuilderDsl
    {
        public ReviewCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ReviewCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new ReviewCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ReviewCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ReviewCreatedMessagePayloadQueryBuilderDsl>(p, ReviewCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReviewCreatedMessagePayloadQueryBuilderDsl> Review(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("review"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl.Of())),
                ReviewCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
