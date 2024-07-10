using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StagedQuotes
{

    public partial class StagedQuoteTransitionStateActionQueryBuilderDsl
    {
        public StagedQuoteTransitionStateActionQueryBuilderDsl()
        {
        }

        public static StagedQuoteTransitionStateActionQueryBuilderDsl Of()
        {
            return new StagedQuoteTransitionStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedQuoteTransitionStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedQuoteTransitionStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedQuoteTransitionStateActionQueryBuilderDsl>(p, StagedQuoteTransitionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedQuoteTransitionStateActionQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedQuoteTransitionStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateResourceIdentifierQueryBuilderDsl.Of())),
                StagedQuoteTransitionStateActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StagedQuoteTransitionStateActionQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<StagedQuoteTransitionStateActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<StagedQuoteTransitionStateActionQueryBuilderDsl>(p, StagedQuoteTransitionStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
