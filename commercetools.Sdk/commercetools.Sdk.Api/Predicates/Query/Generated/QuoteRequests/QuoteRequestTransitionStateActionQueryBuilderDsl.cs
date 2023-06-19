using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.QuoteRequests
{

    public partial class QuoteRequestTransitionStateActionQueryBuilderDsl
    {
        public QuoteRequestTransitionStateActionQueryBuilderDsl()
        {
        }

        public static QuoteRequestTransitionStateActionQueryBuilderDsl Of()
        {
            return new QuoteRequestTransitionStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestTransitionStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<QuoteRequestTransitionStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<QuoteRequestTransitionStateActionQueryBuilderDsl>(p, QuoteRequestTransitionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestTransitionStateActionQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestTransitionStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                QuoteRequestTransitionStateActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteRequestTransitionStateActionQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<QuoteRequestTransitionStateActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<QuoteRequestTransitionStateActionQueryBuilderDsl>(p, QuoteRequestTransitionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
