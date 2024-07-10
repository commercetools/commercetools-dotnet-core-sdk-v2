using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl
    {
        public QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl()
        {
        }

        public static QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl Of()
        {
            return new QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl>(p, QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl.Of);
        }

        public CombinationQueryPredicate<QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl> OldState(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("oldState"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl>(p, QuoteRequestStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
