using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StagedQuotes
{

    public partial class StagedQuoteUpdateActionQueryBuilderDsl
    {
        public StagedQuoteUpdateActionQueryBuilderDsl()
        {
        }

        public static StagedQuoteUpdateActionQueryBuilderDsl Of()
        {
            return new StagedQuoteUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedQuoteUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl>(p, StagedQuoteUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl> AsChangeStagedQuoteState(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteChangeStagedQuoteStateActionQueryBuilderDsl.Of()),
                StagedQuoteUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetCustomFieldActionQueryBuilderDsl.Of()),
                StagedQuoteUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetCustomTypeActionQueryBuilderDsl.Of()),
                StagedQuoteUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl> AsSetSellerComment(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetSellerCommentActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetSellerCommentActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetSellerCommentActionQueryBuilderDsl.Of()),
                StagedQuoteUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl> AsSetValidTo(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetValidToActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetValidToActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteSetValidToActionQueryBuilderDsl.Of()),
                StagedQuoteUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl> AsTransitionState(
            Func<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteTransitionStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteTransitionStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.StagedQuotes.StagedQuoteTransitionStateActionQueryBuilderDsl.Of()),
                StagedQuoteUpdateActionQueryBuilderDsl.Of);
        }
    }
}
