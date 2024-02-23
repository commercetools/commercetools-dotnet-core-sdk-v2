using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.QuoteRequests
{

    public partial class QuoteRequestUpdateActionQueryBuilderDsl
    {
        public QuoteRequestUpdateActionQueryBuilderDsl()
        {
        }

        public static QuoteRequestUpdateActionQueryBuilderDsl Of()
        {
            return new QuoteRequestUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<QuoteRequestUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<QuoteRequestUpdateActionQueryBuilderDsl>(p, QuoteRequestUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<QuoteRequestUpdateActionQueryBuilderDsl> AsChangeCustomer(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestChangeCustomerActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestChangeCustomerActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestChangeCustomerActionQueryBuilderDsl.Of()),
                QuoteRequestUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<QuoteRequestUpdateActionQueryBuilderDsl> AsChangeQuoteRequestState(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestChangeQuoteRequestStateActionQueryBuilderDsl.Of()),
                QuoteRequestUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<QuoteRequestUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestSetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestSetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestSetCustomFieldActionQueryBuilderDsl.Of()),
                QuoteRequestUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<QuoteRequestUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestSetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestSetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestSetCustomTypeActionQueryBuilderDsl.Of()),
                QuoteRequestUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<QuoteRequestUpdateActionQueryBuilderDsl> AsTransitionState(
            Func<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestTransitionStateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestTransitionStateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.QuoteRequests.QuoteRequestTransitionStateActionQueryBuilderDsl.Of()),
                QuoteRequestUpdateActionQueryBuilderDsl.Of);
        }
    }
}
