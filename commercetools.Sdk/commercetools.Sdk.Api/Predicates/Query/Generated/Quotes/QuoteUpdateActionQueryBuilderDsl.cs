using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Quotes
{

    public partial class QuoteUpdateActionQueryBuilderDsl
    {
        public QuoteUpdateActionQueryBuilderDsl()
        {
        }

        public static QuoteUpdateActionQueryBuilderDsl Of()
        {
            return new QuoteUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<QuoteUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl>(p, QuoteUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl> AsChangeCustomer(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteChangeCustomerActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteChangeCustomerActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteChangeCustomerActionQueryBuilderDsl.Of()),
                QuoteUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl> AsChangeQuoteState(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteChangeQuoteStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteChangeQuoteStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteChangeQuoteStateActionQueryBuilderDsl.Of()),
                QuoteUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl> AsRequestQuoteRenegotiation(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteRequestQuoteRenegotiationActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteRequestQuoteRenegotiationActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteRequestQuoteRenegotiationActionQueryBuilderDsl.Of()),
                QuoteUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteSetCustomFieldActionQueryBuilderDsl.Of()),
                QuoteUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteSetCustomTypeActionQueryBuilderDsl.Of()),
                QuoteUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl> AsTransitionState(
            Func<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteTransitionStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteTransitionStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Quotes.QuoteTransitionStateActionQueryBuilderDsl.Of()),
                QuoteUpdateActionQueryBuilderDsl.Of);
        }
    }
}
