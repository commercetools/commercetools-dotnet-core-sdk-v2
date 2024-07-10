using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ReviewRatingSetMessagePayloadQueryBuilderDsl
    {
        public ReviewRatingSetMessagePayloadQueryBuilderDsl()
        {
        }

        public static ReviewRatingSetMessagePayloadQueryBuilderDsl Of()
        {
            return new ReviewRatingSetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewRatingSetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ReviewRatingSetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ReviewRatingSetMessagePayloadQueryBuilderDsl>(p, ReviewRatingSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewRatingSetMessagePayloadQueryBuilderDsl, decimal> OldRating()
        {
            return new ComparisonPredicateBuilder<ReviewRatingSetMessagePayloadQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldRating")),
            p => new CombinationQueryPredicate<ReviewRatingSetMessagePayloadQueryBuilderDsl>(p, ReviewRatingSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewRatingSetMessagePayloadQueryBuilderDsl, decimal> NewRating()
        {
            return new ComparisonPredicateBuilder<ReviewRatingSetMessagePayloadQueryBuilderDsl, decimal>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newRating")),
            p => new CombinationQueryPredicate<ReviewRatingSetMessagePayloadQueryBuilderDsl>(p, ReviewRatingSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewRatingSetMessagePayloadQueryBuilderDsl, bool> IncludedInStatistics()
        {
            return new ComparisonPredicateBuilder<ReviewRatingSetMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("includedInStatistics")),
            p => new CombinationQueryPredicate<ReviewRatingSetMessagePayloadQueryBuilderDsl>(p, ReviewRatingSetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReviewRatingSetMessagePayloadQueryBuilderDsl> Target(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewRatingSetMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("target"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.ReferenceQueryBuilderDsl.Of())),
                ReviewRatingSetMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
