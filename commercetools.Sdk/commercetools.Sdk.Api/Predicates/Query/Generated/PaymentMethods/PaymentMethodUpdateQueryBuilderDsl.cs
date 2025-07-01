using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.PaymentMethods
{

    public partial class PaymentMethodUpdateQueryBuilderDsl
    {
        public PaymentMethodUpdateQueryBuilderDsl()
        {
        }

        public static PaymentMethodUpdateQueryBuilderDsl Of()
        {
            return new PaymentMethodUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<PaymentMethodUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<PaymentMethodUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<PaymentMethodUpdateQueryBuilderDsl>(p, PaymentMethodUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<PaymentMethodUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<PaymentMethodUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.PaymentMethods.PaymentMethodUpdateActionQueryBuilderDsl.Of())),
                PaymentMethodUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<PaymentMethodUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<PaymentMethodUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<PaymentMethodUpdateQueryBuilderDsl>(p, PaymentMethodUpdateQueryBuilderDsl.Of));
        }

    }
}
