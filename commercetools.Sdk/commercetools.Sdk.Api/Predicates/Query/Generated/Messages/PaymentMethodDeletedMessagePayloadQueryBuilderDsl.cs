using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class PaymentMethodDeletedMessagePayloadQueryBuilderDsl
    {
        public PaymentMethodDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static PaymentMethodDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new PaymentMethodDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<PaymentMethodDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<PaymentMethodDeletedMessagePayloadQueryBuilderDsl>(p, PaymentMethodDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodDeletedMessagePayloadQueryBuilderDsl> PaymentMethod(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodDeletedMessagePayloadQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("paymentMethod"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodQueryBuilderDsl.Of())),
                PaymentMethodDeletedMessagePayloadQueryBuilderDsl.Of);
        }


    }
}
