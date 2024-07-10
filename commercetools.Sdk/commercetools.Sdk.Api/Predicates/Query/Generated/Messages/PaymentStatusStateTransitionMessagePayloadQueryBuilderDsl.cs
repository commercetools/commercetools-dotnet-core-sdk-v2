using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl
    {
        public PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl>(p, PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.States.StateReferenceQueryBuilderDsl.Of())),
                PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl, bool> Force()
        {
            return new ComparisonPredicateBuilder<PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("force")),
            p => new CombinationQueryPredicate<PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl>(p, PaymentStatusStateTransitionMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
