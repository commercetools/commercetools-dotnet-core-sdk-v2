using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentCreatedMessagePayloadQueryBuilderDsl
    {
        public PaymentCreatedMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentCreatedMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentCreatedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentCreatedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentCreatedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentCreatedMessagePayloadQueryBuilderDsl>(p, PaymentCreatedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentCreatedMessagePayloadQueryBuilderDsl> Payment(
            Func<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentCreatedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("payment"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Payments.PaymentQueryBuilderDsl.Of())),
                PaymentCreatedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
