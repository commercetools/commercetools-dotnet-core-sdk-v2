using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Payments
{

    public partial class PaymentMethodInfoQueryBuilderDsl
    {
        public PaymentMethodInfoQueryBuilderDsl()
        {
        }

        public static PaymentMethodInfoQueryBuilderDsl Of()
        {
            return new PaymentMethodInfoQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodInfoQueryBuilderDsl, string> PaymentInterface()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("paymentInterface")),
            p => new CombinationQueryPredicate<PaymentMethodInfoQueryBuilderDsl>(p, PaymentMethodInfoQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<PaymentMethodInfoQueryBuilderDsl, string> Method()
        {
            return new ComparisonPredicateBuilder<PaymentMethodInfoQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("method")),
            p => new CombinationQueryPredicate<PaymentMethodInfoQueryBuilderDsl>(p, PaymentMethodInfoQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodInfoQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodInfoQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                PaymentMethodInfoQueryBuilderDsl.Of);
        }


    }
}
