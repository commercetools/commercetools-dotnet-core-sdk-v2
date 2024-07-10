using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewReferenceQueryBuilderDsl
    {
        public ReviewReferenceQueryBuilderDsl()
        {
        }

        public static ReviewReferenceQueryBuilderDsl Of()
        {
            return new ReviewReferenceQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewReferenceQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<ReviewReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<ReviewReferenceQueryBuilderDsl>(p, ReviewReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewReferenceQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<ReviewReferenceQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<ReviewReferenceQueryBuilderDsl>(p, ReviewReferenceQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReviewReferenceQueryBuilderDsl> Obj(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewReferenceQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("obj"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewQueryBuilderDsl.Of())),
                ReviewReferenceQueryBuilderDsl.Of);
        }


    }
}
