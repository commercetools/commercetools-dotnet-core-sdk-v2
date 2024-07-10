using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewDraftQueryBuilderDsl
    {
        public ReviewDraftQueryBuilderDsl()
        {
        }

        public static ReviewDraftQueryBuilderDsl Of()
        {
            return new ReviewDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ReviewDraftQueryBuilderDsl>(p, ReviewDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string> UniquenessValue()
        {
            return new ComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("uniquenessValue")),
            p => new CombinationQueryPredicate<ReviewDraftQueryBuilderDsl>(p, ReviewDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<ReviewDraftQueryBuilderDsl>(p, ReviewDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string> AuthorName()
        {
            return new ComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("authorName")),
            p => new CombinationQueryPredicate<ReviewDraftQueryBuilderDsl>(p, ReviewDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string> Title()
        {
            return new ComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("title")),
            p => new CombinationQueryPredicate<ReviewDraftQueryBuilderDsl>(p, ReviewDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string> Text()
        {
            return new ComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("text")),
            p => new CombinationQueryPredicate<ReviewDraftQueryBuilderDsl>(p, ReviewDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string> Target()
        {
            return new ComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("target")),
            p => new CombinationQueryPredicate<ReviewDraftQueryBuilderDsl>(p, ReviewDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReviewDraftQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                ReviewDraftQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, long> Rating()
        {
            return new ComparisonPredicateBuilder<ReviewDraftQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("rating")),
            p => new CombinationQueryPredicate<ReviewDraftQueryBuilderDsl>(p, ReviewDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ReviewDraftQueryBuilderDsl> Customer(
            Func<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("customer"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Customers.CustomerResourceIdentifierQueryBuilderDsl.Of())),
                ReviewDraftQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<ReviewDraftQueryBuilderDsl> Custom(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("custom"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsDraftQueryBuilderDsl.Of())),
                ReviewDraftQueryBuilderDsl.Of);
        }


    }
}
