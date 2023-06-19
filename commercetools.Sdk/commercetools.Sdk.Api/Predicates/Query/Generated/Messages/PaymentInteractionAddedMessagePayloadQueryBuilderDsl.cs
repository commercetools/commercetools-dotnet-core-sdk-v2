using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentInteractionAddedMessagePayloadQueryBuilderDsl
    {
        public PaymentInteractionAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentInteractionAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentInteractionAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentInteractionAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentInteractionAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentInteractionAddedMessagePayloadQueryBuilderDsl>(p, PaymentInteractionAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentInteractionAddedMessagePayloadQueryBuilderDsl> Interaction(
            Func<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentInteractionAddedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("interaction"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Types.CustomFieldsQueryBuilderDsl.Of())),
                PaymentInteractionAddedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
