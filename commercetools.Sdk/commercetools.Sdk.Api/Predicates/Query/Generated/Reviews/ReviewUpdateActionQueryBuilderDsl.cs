using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Reviews
{

    public partial class ReviewUpdateActionQueryBuilderDsl
    {
        public ReviewUpdateActionQueryBuilderDsl()
        {
        }

        public static ReviewUpdateActionQueryBuilderDsl Of()
        {
            return new ReviewUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ReviewUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ReviewUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(p, ReviewUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl> AsSetAuthorName(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetAuthorNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetAuthorNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetAuthorNameActionQueryBuilderDsl.Of()),
                ReviewUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetCustomFieldActionQueryBuilderDsl.Of()),
                ReviewUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetCustomTypeActionQueryBuilderDsl.Of()),
                ReviewUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl> AsSetCustomer(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetCustomerActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetCustomerActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetCustomerActionQueryBuilderDsl.Of()),
                ReviewUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetKeyActionQueryBuilderDsl.Of()),
                ReviewUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl> AsSetLocale(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetLocaleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetLocaleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetLocaleActionQueryBuilderDsl.Of()),
                ReviewUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl> AsSetRating(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetRatingActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetRatingActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetRatingActionQueryBuilderDsl.Of()),
                ReviewUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl> AsSetTarget(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetTargetActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetTargetActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetTargetActionQueryBuilderDsl.Of()),
                ReviewUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl> AsSetText(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetTextActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetTextActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetTextActionQueryBuilderDsl.Of()),
                ReviewUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl> AsSetTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetTitleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetTitleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewSetTitleActionQueryBuilderDsl.Of()),
                ReviewUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl> AsTransitionState(
            Func<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewTransitionStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewTransitionStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ReviewUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Reviews.ReviewTransitionStateActionQueryBuilderDsl.Of()),
                ReviewUpdateActionQueryBuilderDsl.Of);
        }
    }
}
