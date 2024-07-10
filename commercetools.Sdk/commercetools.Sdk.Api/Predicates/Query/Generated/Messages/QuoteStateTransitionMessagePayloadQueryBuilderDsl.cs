using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteStateTransitionMessagePayloadQueryBuilderDsl
    {
        public QuoteStateTransitionMessagePayloadQueryBuilderDsl()
        {
        }

        public static QuoteStateTransitionMessagePayloadQueryBuilderDsl Of()
        {
            return new QuoteStateTransitionMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteStateTransitionMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteStateTransitionMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteStateTransitionMessagePayloadQueryBuilderDsl>(p, QuoteStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteStateTransitionMessagePayloadQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteStateTransitionMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                QuoteStateTransitionMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteStateTransitionMessagePayloadQueryBuilderDsl> OldState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteStateTransitionMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                QuoteStateTransitionMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteStateTransitionMessagePayloadQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<QuoteStateTransitionMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<QuoteStateTransitionMessagePayloadQueryBuilderDsl>(p, QuoteStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
