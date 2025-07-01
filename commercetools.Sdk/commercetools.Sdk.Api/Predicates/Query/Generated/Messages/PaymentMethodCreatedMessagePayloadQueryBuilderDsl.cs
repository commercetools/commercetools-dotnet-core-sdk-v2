using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodCreatedMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodCreatedMessagePayloadQueryBuilderDsl>(p, PaymentMethodCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodCreatedMessagePayloadQueryBuilderDsl> PaymentMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl.Of())),
                PaymentMethodCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
